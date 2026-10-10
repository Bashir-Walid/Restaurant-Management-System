using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MenuCategoryMappingExtension
    {
        public static MenuCategory ToModel(this MenuCategoryViewModels model)
        {
            return new MenuCategory
            {
                Name = model.Name,
               
                id = model.id,     
                IsActive=model.IsActive,


            };
        }
        public static MenuCategoryViewModels ToViewModel(this MenuCategory model)
        {
            return new MenuCategoryViewModels
            {
                Name = model.Name,


                id = model.id,
                IsActive = model.IsActive,


            };
        }
        public static List<MenuCategoryViewModels> ToViewModelList(this List<MenuCategory> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<MenuCategory> ToModelList(this List<MenuCategoryViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
