using System.ComponentModel.DataAnnotations;

namespace ConsoleSleepTracker.Entities
{
    public class Day
    {
        public int Id { get; set; }
       /* public string Name { get; set; } // this needs for interface, like: 1.1.2023
       */ [DataType(DataType.Date)]
        public DateTime Date { get; set; } // 01.01.2023
        [DataType(DataType.Time)]
        public DateTime GoToSleepTime { get; set; } //12:00
        [DataType(DataType.Time)]
        public DateTime GetUpTime { get; set; } //9:00
    }
}
