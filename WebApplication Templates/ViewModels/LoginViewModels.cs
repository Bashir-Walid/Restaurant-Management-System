using System.ComponentModel.DataAnnotations;

namespace WebApplication_Templates.ViewModels
{
    public class LoginViewModels
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
