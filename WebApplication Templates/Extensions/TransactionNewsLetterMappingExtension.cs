using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class TransactionNewsLetterMappingExtension
    {
        public static TransactionNewsLetter ToModel(this TransactionNewsLetterViewModels model)
        {
            return new TransactionNewsLetter
            {
                id = model.id,
                IsActive = model.IsActive,
                Email = model.Email,


            };
        }
        public static TransactionNewsLetterViewModels ToViewModel(this TransactionNewsLetter model)
        {
            return new TransactionNewsLetterViewModels
            {
                id = model.id,
                IsActive = model.IsActive,
                Email = model.Email,

            };
        }
        public static List<TransactionNewsLetterViewModels> ToViewModelList(this List<TransactionNewsLetter> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();
        }
        public static List<TransactionNewsLetter> ToModelList(this List<TransactionNewsLetterViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
