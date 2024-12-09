namespace TigerTix.Entities
{
    public class Review
    {
        public int Id { get; set; } // Primary Key
        public string UserName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; } // Rating from 1 to 5
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int EventId { get; set; } // Foreign key to Product (assumed)
    }
}
