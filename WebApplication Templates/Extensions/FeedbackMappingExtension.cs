using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class FeedbackMappingExtension
    {
        public static Feedback ToModel(this FeedbackViewModels model)
        {
            return new Feedback
            {
                Image = model.Image,
                Name = model.Name,
                Title = model.Title,
                Feedbacks = model.Feedbacks,
                id=model.id,     
                IsActive=model.IsActive,


            };
        }
        public static FeedbackViewModels ToViewModel(this Feedback model)
        {
            return new FeedbackViewModels
            {
                Image = model.Image,
                Name = model.Name,
                Title = model.Title,
                Feedbacks = model.Feedbacks,
                id = model.id,
                IsActive = model.IsActive,

            };
        }
        public static List<FeedbackViewModels> ToViewModelList(this List<Feedback> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<Feedback> ToModelList(this List<FeedbackViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
