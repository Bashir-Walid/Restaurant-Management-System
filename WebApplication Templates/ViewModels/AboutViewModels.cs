namespace WebApplication_Templates.ViewModels
{
    public class AboutViewModels
    {
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Desc { get; set; }
        public string? Image { get; set; }
        public string FooterDesc { get; set; }
        public IFormFile? ImageFile { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
