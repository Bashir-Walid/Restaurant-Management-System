using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class BannerMappingExtension
    {
        public static Banner ToModel(this BannerViewModels model)
        {
            return new Banner
            {
                Image = model.Image,
                Desc = model.Desc,
                Title = model.Title,
                Brief = model.Brief,
                id=model.id,     
                IsActive=model.IsActive,
                IsPrimary = model.IsPrimary,


            };
        }
        public static BannerViewModels ToViewModel(this Banner model)
        {
            return new BannerViewModels
            {
                Image = model.Image,
                Desc = model.Desc,
                Title = model.Title,
                Brief = model.Brief,
                id = model.id,
                IsActive = model.IsActive,
                IsPrimary= model.IsPrimary,

            };
        }
        public static List<BannerViewModels> ToViewModelList(this List<Banner> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<Banner> ToModelList(this List<BannerViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
