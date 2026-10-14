namespace Byte64
{
    public class Station
    {
        public Station(int stationId, int bedCount)
        {
            StationId = stationId;
            BedCount = bedCount;
        }

        public int StationId { get; set; }
        public int BedCount { get; set; }
    }
}
