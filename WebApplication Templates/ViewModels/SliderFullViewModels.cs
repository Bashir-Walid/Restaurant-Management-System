namespace WebApplication_Templates.ViewModels
{
    public class SliderFullViewModels
    {
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Desc { get; set; }
        public string? Image { get; set; }
        public IFormFile? ImageFile { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<SliderViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}
