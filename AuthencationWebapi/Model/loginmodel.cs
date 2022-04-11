using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthencationWebapi.Model
{
    public class loginmodel
    {
        [Required, Display(Name = "Email Id")]
        [EmailAddress]
        [Column(TypeName = "Nvarchar(255)")]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Column(TypeName = "Nvarchar(15)"), Display(Name = "Password")]
        public string password { get; set; }
    }
}
