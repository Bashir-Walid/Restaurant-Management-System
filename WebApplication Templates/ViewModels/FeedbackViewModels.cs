namespace WebApplication_Templates.ViewModels
{
    public class FeedbackViewModels
    {
        public string Title { get; set; }
        public string Feedbacks { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public IFormFile? ImageFile { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
