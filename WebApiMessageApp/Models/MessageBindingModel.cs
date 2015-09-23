using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMessageApp.Models
{
    public class MessageBindingModel
    {
        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Message body")]
        [DataType(DataType.MultilineText)]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength =5)]
        public string Message { get; set; }
    }
}