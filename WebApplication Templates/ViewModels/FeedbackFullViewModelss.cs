namespace WebApplication_Templates.ViewModels
{
    public class FeedbackFullViewModels
    {
        public string Title { get; set; }
        public string Feedbacks { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public IFormFile? ImageFile { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<FeedbackViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}
