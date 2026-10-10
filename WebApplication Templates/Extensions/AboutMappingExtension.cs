using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class AboutMappingExtension
    {
        public static About ToModel(this AboutViewModels model)
        {
            return new About
            {
                Image = model.Image,
                Desc = model.Desc,
                Title = model.Title,
                Brief = model.Brief,
                FooterDesc= model.FooterDesc,
                id = model.id,     
                IsActive=model.IsActive,


            };
        }
        public static AboutViewModels ToViewModel(this About model)
        {
            return new AboutViewModels
            {
                Image = model.Image,
                Desc = model.Desc,
                Title = model.Title,
                Brief = model.Brief,
                id = model.id,
                IsActive = model.IsActive,
                FooterDesc = model.FooterDesc,


            };
        }
        public static List<AboutViewModels> ToViewModelList(this List<About> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<About> ToModelList(this List<AboutViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
