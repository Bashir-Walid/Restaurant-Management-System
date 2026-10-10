namespace WebApplication_Templates.ViewModels
{
    public class MenuItemsFullViewModels
    {
        public string Image { get; set; }
        public string Title { get; set; }

        public string FirstDesc { get; set; }

        public string Price { get; set; }
        public int MenuCategoryId { get; set; }
        public string Name { get; set; }
        public string? SecondDesc { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; }
        public IFormFile? MenuItemsImageFile { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<MenuItemsViewModels> list { get; set; }
        public List<MenuCategoryViewModels> listet { get; set; }

        public int DeleteId { get; set; }
        public bool IsMenu { get; set; }

    }
}
