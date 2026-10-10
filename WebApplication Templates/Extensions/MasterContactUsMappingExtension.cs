using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterContactUsMappingExtension
    {
        public static MasterContactUs ToModel(this MasterContactUsViewModles model)
        {
            return new MasterContactUs
            {
                IsActive = model.IsActive,
                id = model.id,
                Link = model.Link,
                Icon= model.Icon,
                Text= model.Text,
     
            };
        }
        public static MasterContactUsViewModles ToViewModel(this MasterContactUs model)
        {
            return new MasterContactUsViewModles
            {
                IsActive = model.IsActive,
                id = model.id,
                Link = model.Link,
                Icon = model.Icon,
                Text = model.Text,

            };
        }
        public static List<MasterContactUsViewModles> ToViewModelList(this List<MasterContactUs> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterContactUs> ToModelList(this List<MasterContactUsViewModles> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
