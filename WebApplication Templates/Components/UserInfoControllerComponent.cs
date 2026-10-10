using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Templates.Components
{
    public class UserInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default", User.Identity?.Name);
        }
    }
}