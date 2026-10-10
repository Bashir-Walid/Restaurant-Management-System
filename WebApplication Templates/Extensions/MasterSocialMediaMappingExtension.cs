using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterSocialMediaMappingExtension
    {
        public static MasterSocialMedia ToModel(this MasterSocialMediaViewModles model)
        {
            return new MasterSocialMedia
            {
                IsActive = model.IsActive,
                id = model.id,
                Link = model.Link,
                Icon= model.Icon,
     
            };
        }
        public static MasterSocialMediaViewModles ToViewModel(this MasterSocialMedia model)
        {
            return new MasterSocialMediaViewModles
            {
                IsActive = model.IsActive,
                id = model.id,
                Link = model.Link,
                Icon = model.Icon,
            };
        }
        public static List<MasterSocialMediaViewModles> ToViewModelList(this List<MasterSocialMedia> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterSocialMedia> ToModelList(this List<MasterSocialMediaViewModles> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
