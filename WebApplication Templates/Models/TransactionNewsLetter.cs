using System.ComponentModel.DataAnnotations;

namespace WebApplication_Templates.Models
{
    public class TransactionNewsLetter :BaseEntity
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
