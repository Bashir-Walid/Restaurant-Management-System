namespace WebApplication_Templates.ViewModels
{
    public class BannerFullViewModels
    {
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Desc { get; set; }
        public string? Image { get; set; }
        public bool IsPrimary { get; set; }
        public IFormFile? ImageFile { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<BannerViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}
