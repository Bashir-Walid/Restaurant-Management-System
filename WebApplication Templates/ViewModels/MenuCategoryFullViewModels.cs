namespace WebApplication_Templates.ViewModels
{
    public class MenuCategoryFullViewModels
    {
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public string Name { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MenuCategoryViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}
