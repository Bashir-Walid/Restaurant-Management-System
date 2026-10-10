using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MenuItemsMappingExtension
    {
        public static MenuItems ToModel(this MenuItemsViewModels model)
        {
            return new MenuItems
            {
                Image = model.Image,
                FirstDesc = model.FirstDesc,
                Title = model.Title,
                Price = model.Price,
                SecondDesc = model.SecondDesc,
                id = model.id,     
                IsActive=model.IsActive,
                MenuCategoryId = model.MenuCategoryId,
                IsMenu = model.IsMenu,

            };
        }
        public static MenuItemsViewModels ToViewModel(this MenuItems model)
        {
            return new MenuItemsViewModels
            {
                Image = model.Image,
                FirstDesc = model.FirstDesc,
                Title = model.Title,
                Price = model.Price,
                SecondDesc = model.SecondDesc,
                id = model.id,
                IsActive = model.IsActive,
                MenuCategoryId = model.MenuCategoryId,
                IsMenu = model.IsMenu,

            };
        }
        public static List<MenuItemsViewModels> ToViewModelList(this List<MenuItems> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<MenuItems> ToModelList(this List<MenuItemsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
