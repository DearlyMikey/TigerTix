using TigerTix.Entities;

namespace TigerTix.Models
{
    public class ReveiwModel
    {
        public class ReviewViewModel
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Comment { get; set; }
            public int Rating { get; set; }
            public DateTime CreatedAt { get; set; }
            public int EventId { get; set; }
    }
    }
}
