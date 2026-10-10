namespace WebApplication_Templates.ViewModels
{
    public class TransactionReservationViewModels
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? AvailableDate { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? Datesent { get; set; }

    }
}
