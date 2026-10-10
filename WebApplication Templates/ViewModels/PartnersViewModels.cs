namespace WebApplication_Templates.ViewModels
{
    public class PartnersViewModels
    {
        public string? Image { get; set; }
        public string? Alt { get; set; }
        public string Link { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public IFormFile? ImageFile { get; set; }
        public IFormFile? ImageFile1 { get; set; }

    }
}
