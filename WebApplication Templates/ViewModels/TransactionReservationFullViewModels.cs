namespace WebApplication_Templates.ViewModels
{
    public class TransactionReservationFullViewModels
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? AvailableDate { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<TransactionReservationViewModels> list { get; set; }
        public int DeleteId { get; set; }
        public DateTime? Datesent { get; set; }
        
    }
}
