namespace WebApplication_Templates.ViewModels
{
    public class MasterContactUsFullViewModles
    {
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
        public int id { get; set; }
        public List<MasterContactUsViewModles> list { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; set; }
        public int DeleteId { get; set; }
        public string Text { get; set; }


    }
}
