// See https://aka.ms/new-console-template for more information

using Microsoft.Data.Sqlite;

/*Console.WriteLine("The Pokemon Database is located at:");
Console.WriteLine(Path.Combine(AppContext.BaseDirectory, "Data", "pokemon.db"));*/

/*var bisasamTmp = repo.GetByDexNo(151);
var bisasam = new PokemonInstance(bisasamTmp, 6);
Console.WriteLine("Your pokemon of type " + bisasam.Species.Type1 + " with the name " + bisasam.Species.Name
                    + " is at Level " + bisasam.Level);*/


var path = Path.Combine(AppContext.BaseDirectory, "Data", "pokemon.db");
var repo = new PokemonRepository(path); 
/*var pokeList = repo.GetAllPokemons();
foreach (var pokeSpecies in pokeList)
{
    Console.WriteLine(pokeSpecies.Name + " " + pokeSpecies.Type1 + " " + pokeSpecies.Type2);
}*/
/*Console.WriteLine(repo.CountAllPokemons());*/

var pokeIndexList = repo.GetAllIndices();
foreach (var pokeIndex in pokeIndexList)
{
    Console.WriteLine(pokeIndex);
}



public sealed class PokemonInstance // no other class can inherit from a sealed class
{
    /*A GUID is a 128-bit integer (16 bytes) that can be used across all computers and networks wherever a 
    unique identifier is required. Such an identifier has a very low probability of being duplicated.*/
    public Guid InstanceId { get; } = Guid.NewGuid();

    public int Level { get; private set; }
    
    public int Exp { get; private set; }
    
    public int CurrentHp { get; private set; }
    
    public int MaxHp { get; private set; }

    public PokemonSpecies Species { get; }
    
    // public string Name { get; set; } = "Thorsten"; // sets the default name to "Thorsten" if no name is provided during initialization

    public PokemonInstance(PokemonSpecies species, int level)
    {
        Species = species;
        Level = level;
    }
    
    public void GainExp(int exp)
    {
        Exp += exp;
    }
}

public sealed class PokemonRepository
{
    private readonly string _dbPath;
    public PokemonRepository (string dbPath) => _dbPath = dbPath;

    public List<PokemonSpecies> GetAllPokemons()
    {
        var pokeList = new List<PokemonSpecies>();
        
        var pokeIndexList = GetAllIndices();

        foreach (var pokeIndex in pokeIndexList)
        {
            pokeList.Add(GetByDexNo(pokeIndex));
        }
    
        /*for (int i = 1; i < 1000; i++)
        {
            try
            {
                pokeList.Add(GetByDexNo(i));
            }
            catch (Exception e)
            { 
                
            }
        }*/
        return pokeList;
    }
    
    public PokemonSpecies GetByDexNo(int dexNo)
    {
        using var con = new SqliteConnection($"Data Source={_dbPath}");
        con.Open();
        
        // using for the command ensures that the command is disposed of properly after use, preventing resource leaks
        using var cmd = con.CreateCommand();
        cmd.CommandText = """
                          SELECT p.pokemon_id, p.dex_no, p.name, p.is_legendary,
                                 t1.name AS type1, t2.name AS type2,
                                 a.name AS active_ability
                          FROM Pokemon p
                          LEFT JOIN Pokemon_Type pt1 ON pt1.pokemon_id = p.pokemon_id AND pt1.slot = 1
                          LEFT JOIN Type t1 ON t1.type_id = pt1.type_id
                          LEFT JOIN Pokemon_Type pt2 ON pt2.pokemon_id = p.pokemon_id AND pt2.slot = 2
                          LEFT JOIN Type t2 ON t2.type_id = pt2.type_id
                          LEFT JOIN Pokemon_Ability pa ON pa.pokemon_id = p.pokemon_id AND pa.is_active = 1
                          LEFT JOIN Ability a ON a.ability_id = pa.ability_id
                          WHERE p.dex_no = $dex;
                          """;
        cmd.Parameters.AddWithValue("$dex", dexNo); // dynamic parameter binding, prevents SQL injection attacks

        using var r = cmd.ExecuteReader();
        if (!r.Read())
            throw new InvalidOperationException($"Kein Pokémon mit DexNr {dexNo} gefunden!");

        return new PokemonSpecies
        {
            PokemonId = r.GetInt32(r.GetOrdinal("pokemon_id")),
            DexNo = r.GetInt32(r.GetOrdinal("dex_no")),
            Name = r.GetString(r.GetOrdinal("name")),
            IsLegendary = r.GetInt32(r.GetOrdinal("is_legendary")) == 1,
            Type1 = r.IsDBNull(r.GetOrdinal("type1")) ? "" : r.GetString(r.GetOrdinal("type1")),
            Type2 = r.IsDBNull(r.GetOrdinal("type2")) ? null : r.GetString(r.GetOrdinal("type2")),
            ActiveAbility = r.IsDBNull(r.GetOrdinal("active_ability"))
                ? ""
                : r.GetString(r.GetOrdinal("active_ability")),
        };
    }
    
    public int CountAllPokemons()
    {
        using var con = new SqliteConnection($"Data Source={_dbPath}");
        con.Open();

        using var cmd = con.CreateCommand();
        cmd.CommandText = """
                          SELECT COUNT(name)
                          FROM Pokemon
                          ;
                          """;
        
        return Convert.ToInt32(cmd.ExecuteScalar());
    }
    
    public List<int> GetAllIndices()
    {
        using var con = new SqliteConnection($"Data Source={_dbPath}");
        con.Open();

        using var cmd = con.CreateCommand();
        cmd.CommandText = """
                          SELECT dex_no
                          FROM Pokemon
                          ORDER BY pokemon_id;
                          """;                  // without "ORDER BY pokemon_id" the list is not sorted by the pokemon_id, but by the dex_no, which is not what we want
        using var reader = cmd.ExecuteReader();

        var pokemonIndexList = new List<int>();
        
        while (reader.Read())
        {
            pokemonIndexList.Add(Convert.ToInt16(reader.GetString(0)));
        }
        return pokemonIndexList;
    }
}


public sealed class PokemonSpecies
{
    public int PokemonId { get; init; } // init == can only be set during object initialization, not modified later
    
    public int DexNo { get; init; }
    
    public string? Name { get; init; }
    
    public bool IsLegendary { get; init; }
    
    public string? Type1 { get; init; }
    
    public string? Type2 { get; init; }
    
    public string? ActiveAbility { get; init; }
 
}