using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tandfuae.Models
{
    [Table("ContactUs")]
    public class ContactUs
    {
        [Key]
        public int ContactUsKey { get; set; }
        [Required]
        public string ProjectCode { get; set; }
        [Required]
        public string Name { get; set; }
        public string Subject { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email Address")]
        public string Email { get; set; }
        public string Message { get; set; }
        [Display(Name="Phone Numer")]
        public string Phone { get; set; }
        [Display(Name="Company Name")]
        public string CompanyName { get; set; }
        [Display(Name="Created At")]
        public DateTime CreatdAt { get; set; }

    }
}
