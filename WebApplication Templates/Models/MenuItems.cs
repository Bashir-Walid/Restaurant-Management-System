using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Models
{
    public class MenuItems:BaseEntity
    {
        //Table MenuItems: Id / Image / Title / FirstDesc / Price / MenuCategoryId / SecondDesc?

        public string Image { get; set; }
        public string Title { get; set; }

        public string FirstDesc { get; set; }

        public string Price { get; set; }
        public int MenuCategoryId { get; set; }
        public MenuCategory MenuCategory { get; set; }

        public string? SecondDesc { get; set; }
        public bool IsMenu { get; set; }


    }
}
