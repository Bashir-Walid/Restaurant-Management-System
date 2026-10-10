namespace WebApplication_Templates.ViewModels
{
    public class PartnersFullViewModels
    {
        public string? Image { get; set; }
        public string? Alt { get; set; }
        public string Link { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public IFormFile? ImageFile { get; set; }
        public IFormFile? ImageFile1 { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<PartnersViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}
