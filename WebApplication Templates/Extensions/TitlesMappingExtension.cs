using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;
using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class TitlesMappingExtension
    {
        public static Titles ToModel(this TitlesViewModels model)
        {
            return new Titles
            {
                IsActive = model.IsActive,
               Title=model.Title,
                id = model.id,
                Keyword=model.Keyword,
               Desc=model.Desc

            };
        }
        public static TitlesViewModels ToViewModel(this Titles model)
        {
            return new TitlesViewModels
            {
                IsActive = model.IsActive,
                Title = model.Title,
                id = model.id,
                Keyword = model.Keyword,
                Desc = model.Desc
            };
        }
        public static List<TitlesViewModels> ToViewModelList(this List<Titles> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }
        public static List<Titles> ToModelList(this List<TitlesViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();

        }
    }
}
