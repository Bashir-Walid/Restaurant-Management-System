using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Helpers.Email
{
    public interface IEmailHelper
    {
        void SendMessage(EmialViewModels model);
    }
}
