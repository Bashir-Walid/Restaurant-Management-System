using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class TransactionReservationMappingExtension
    {
        public static TransactionReservation ToModel(this TransactionReservationViewModels model)
        {
            return new TransactionReservation
            {
                id = model.id,
                IsActive = model.IsActive,
                FullName = model.FullName,
                EmailAddress = model.EmailAddress,
                MobileNumber = model.MobileNumber,
                AvailableDate = model.AvailableDate?? DateTime.Now,
                Datesent= model.Datesent ?? DateTime.Now,


            };
        }
        public static TransactionReservationViewModels ToViewModel(this TransactionReservation model)
        {
            return new TransactionReservationViewModels
            {
                id = model.id,
                IsActive = model.IsActive,
                FullName = model.FullName,
                EmailAddress = model.EmailAddress,
                MobileNumber = model.MobileNumber,
                AvailableDate = model.AvailableDate,
                                Datesent = model.Datesent ?? DateTime.Now,

            };
        }
        public static List<TransactionReservationViewModels> ToViewModelList(this List<TransactionReservation> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<TransactionReservation> ToModelList(this List<TransactionReservationViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
