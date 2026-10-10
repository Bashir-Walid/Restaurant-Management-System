using System.ComponentModel.DataAnnotations;

namespace WebApplication_Templates.ViewModels
{
    public class RegisterViewModels
    {
        public string UserName { get; set; }
        //[DataType(DataType.EmailAddress)]
        //public string Emil { get; set; }

        [DataType(DataType.Password)]

        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password is not matchang ")]
        
        public string ConfirmPassword { get; set; }
    }
}

