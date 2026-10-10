using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class MasterTransactionContactUsMappingExtensions
    {
        public static MasterTransactionContactUs ToModel(this MasterTransactionContactUsViewModel model)
        {
            return new MasterTransactionContactUs
            {

                Message = model.Message,
                Name = model.Name,
                Email = model.Email,
                Subject = model.Subject,
               id= model.id,
               IsActive= model.IsActive,
                Datesent = model.Datesent??DateTime.Now


            };
        }
        public static MasterTransactionContactUsViewModel ToViewModel(this MasterTransactionContactUs model)
        {
            return new MasterTransactionContactUsViewModel
            {

                Message = model.Message,
                Name = model.Name,
                Email = model.Email,
                Subject = model.Subject,
                id = model.id,
                IsActive = model.IsActive,
                Datesent = model.Datesent 

            };
        }
        public static List<MasterTransactionContactUsViewModel> ToViewModelList(this List<MasterTransactionContactUs> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<MasterTransactionContactUs> ToModelList(this List<MasterTransactionContactUsViewModel> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}


