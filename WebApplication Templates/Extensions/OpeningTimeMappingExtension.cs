using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class OpeningTimeMappingExtension
    {
        public static OpeningTime ToModel(this OpeningTimeViewModels model)
        {
            return new OpeningTime
            {
                Day = model.Day,
                StartTime = model.StartTime,
                IsOpen = model.IsOpen,
                EndTime = model.EndTime,
                id=model.id,     
                IsActive=model.IsActive,

       
      
    };
        }
        public static OpeningTimeViewModels ToViewModel(this OpeningTime model)
        {
            return new OpeningTimeViewModels
            {
                Day = model.Day,
                StartTime = model.StartTime,
                IsOpen = model.IsOpen,
                EndTime = model.EndTime,
                id = model.id,
                IsActive = model.IsActive,

            };
        }
        public static List<OpeningTimeViewModels> ToViewModelList(this List<OpeningTime> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<OpeningTime> ToModelList(this List<OpeningTimeViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
