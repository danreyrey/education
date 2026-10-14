namespace Byte64
{
    public class DateCounter
    {
        public DateCounter(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }

        public int GetDifference() => (EndDate - StartDate).Days;
    }
}
