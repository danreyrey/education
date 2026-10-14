using Byte64;

Airplane airplane = new Airplane(12, 12, "green", 12000);
Bicycle bicycle = new Bicycle(12, 12, "green", 12);
Car car = new Car(12, 12, "green", 12);
ConvertibleCar convertibleCar = new ConvertibleCar(12, 12, "green", 12);

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(convertibleCar);
vehicles.Add(car);
vehicles.Add(airplane);
vehicles.Add(bicycle);

foreach (Vehicle vehicle in vehicles)
    vehicle.Move();