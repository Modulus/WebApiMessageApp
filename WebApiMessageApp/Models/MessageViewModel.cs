using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiMessageApp.Models
{
    public class MessageViewModel
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}