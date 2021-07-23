using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Carnation.NewModels
{
    public partial class Feedback
    {
        public int Id { get; set; }
        [Display(Name ="User Name")]
        [Required(ErrorMessage ="UserName is Required")]
        public string Username { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "please write about carnation & the changes to be done")]
        public string Description { get; set; }
        public DateTime? InDate { get; set; }
    }
}
