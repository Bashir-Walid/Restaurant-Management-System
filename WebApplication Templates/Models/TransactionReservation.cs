namespace WebApplication_Templates.Models
{
    public class TransactionReservation :BaseEntity
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? AvailableDate { get; set; }
        public DateTime? Datesent { get; set; }

    }
}
