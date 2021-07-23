using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Carnation.NewModels
{
    public partial class MerchantUserRegister
    {
        public int Muid { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name !")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter last name !")]
        public string LastName { get; set; }
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please fill gender !")]
        public string Gender { get; set; }
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Please enter Age !")]
        public int Age { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter email address !")]
        public string Email { get; set; }
        [Display(Name = "Contact")]
        [Required(ErrorMessage = "Please enter contact no !")]
        [StringLength(10)]
        public string Contact { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please enter unique username !")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter Password !")]
        public string Pass { get; set; }
        public DateTime? CreatedInfo { get; set; }
    }
}
