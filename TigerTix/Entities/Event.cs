using System.ComponentModel.DataAnnotations;

namespace TigerTix.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string? EventName { get; set; }
        public string? EventDescription { get; set; }
        public string? EventType { get; set; }
        [DataType(DataType.Date)]
        public DateTime EventDateTime { get; set; }

    }
}
