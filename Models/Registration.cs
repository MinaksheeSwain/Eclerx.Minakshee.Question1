using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Eclerx.Minakshee.Question1.Models
{
    public class Registration
    {
        [Display(Name = "StudentId")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "please enter UserId")]
        [Display(Name = "UserId")]
        public string UserId { get; set; }
        [Display(Name = "Passwords")]
        public string PassWords { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}