using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizStreamFullStackAssignment.Models
{
    public partial class ContactForm
    {
        [DisplayName("First Name")]
        public string? FName { get; set; }

        [DisplayName("Last Name")]
        public string? LName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }

        [DisplayName("Message")]
        [Column(TypeName = "text")]
        [DataType(DataType.MultilineText)]
        public string? Message { get; set; }
    }
}
