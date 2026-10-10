namespace WebApplication_Templates.ViewModels
{
    public class MasterTransactionContactUsFullViewModel
    {
        public DateTime? Datesent { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MasterTransactionContactUsViewModel> list { get; set; }
        public int DeleteId { get; set; }
        public string ReplyContent { get; set; }

    }
}
