using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class ServicesMappingExtension
    {
        public static Services ToModel(this ServicesViewModles model)
        {
            return new Services
            {
                IsActive = model.IsActive,
                id = model.id,
                Title = model.Title,
                Icon= model.Icon,
                Desc= model.Desc,
     
            };
        }
        public static ServicesViewModles ToViewModel(this Services model)
        {
            return new ServicesViewModles
            {
                IsActive = model.IsActive,
                id = model.id,
                Title = model.Title,
                Icon = model.Icon,
                Desc = model.Desc,

            };
        }
        public static List<ServicesViewModles> ToViewModelList(this List<Services> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<Services> ToModelList(this List<ServicesViewModles> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
