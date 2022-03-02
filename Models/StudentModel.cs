using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class StudentModel
    {
        [Required]
        [Display(Name = "First name ")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name ")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Addres")]
        public string EmailId { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Course")]
        public string Course { get; set; }

        [Required]
        [Display(Name = "Fees")]
        public string Fees { get; set; }

        [Required]
        [Display(Name = "Tax")]
        public string Tax { get; set; }
    }
}
