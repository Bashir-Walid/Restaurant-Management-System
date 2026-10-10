using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class SliderMappingExtension
    {
        public static Slider ToModel(this SliderViewModels model)
        {
            return new Slider
            {
                Image = model.Image,
                Desc = model.Desc,
                Title = model.Title,
                Brief = model.Brief,
                id=model.id,     
                IsActive=model.IsActive,


            };
        }
        public static SliderViewModels ToViewModel(this Slider model)
        {
            return new SliderViewModels
            {
                Image = model.Image,
                Desc = model.Desc,
                Title = model.Title,
                Brief = model.Brief,
                id = model.id,
                IsActive = model.IsActive,

            };
        }
        public static List<SliderViewModels> ToViewModelList(this List<Slider> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<Slider> ToModelList(this List<SliderViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
