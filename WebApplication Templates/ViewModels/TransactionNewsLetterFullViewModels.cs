namespace WebApplication_Templates.ViewModels
{
    public class TransactionNewsLetterFullViewModels
    {
        public string Email { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<TransactionNewsLetterViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}
