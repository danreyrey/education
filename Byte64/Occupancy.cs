namespace Byte64
{
    public class Occupancy
    {
        public Occupancy(int patientId, DateTime dateFrom, DateTime dateTo, int stationId)
        {
            PatientId = patientId;
            DateFrom = dateFrom;
            DateTo = dateTo;
            StationId = stationId;
        }

        public int PatientId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int StationId { get; set; }
    }
}
