using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class PartnersMappingExtension
    {
        public static Partners ToModel(this PartnersViewModels model)
        {
            return new Partners
            {
                Image = model.Image,
                Alt = model.Alt,
                Link = model.Link,
                
                id = model.id,     
                IsActive=model.IsActive,


            };
        }
        public static PartnersViewModels ToViewModel(this Partners model)
        {
            return new PartnersViewModels
            {
                Image = model.Image,
                Alt = model.Alt,
                Link = model.Link,

                id = model.id,
                IsActive = model.IsActive,


            };
        }
        public static List<PartnersViewModels> ToViewModelList(this List<Partners> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<Partners> ToModelList(this List<PartnersViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
