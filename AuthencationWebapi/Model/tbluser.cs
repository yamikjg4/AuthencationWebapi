using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthencationWebapi.Model
{
    public class tbluser
    {
        [Key]
     /*   public int id { get; set; }*/
        [Required]
        [Display(Name ="First Name")]
        [Column(TypeName ="Nvarchar(50)")]
        public string fname { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        [Column(TypeName = "Nvarchar(50)")]
        public string lname { get; set; }
        [Required,Display(Name ="Email Id")]
        [EmailAddress]
        [Column(TypeName ="Nvarchar(255)")]
        public string email { get; set; } 
        [Required]
        [DataType(DataType.Password)]
        [Column(TypeName ="Nvarchar(15)"),Display(Name ="Password")]
        public string password { get; set; }

    }
}
