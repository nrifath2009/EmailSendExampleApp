using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmailSendExampleApp.Models
{
    public class EmailSendModel
    {
        [Required]
        [Display(Name ="Your Name")]
        public string SenderName { get; set; }
        [Required]
        [Display(Name = "Your Email Address")]
        public string SenderEmail { get; set; }
        [Display(Name = "Your Message")]
        public string Message { get; set; }

    }
}