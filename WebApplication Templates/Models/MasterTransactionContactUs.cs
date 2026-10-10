namespace WebApplication_Templates.Models
{
    public class MasterTransactionContactUs :BaseEntity
    {
        public DateTime? Datesent { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
