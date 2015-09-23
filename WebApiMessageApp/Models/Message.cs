using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiMessageApp.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public User Sender { get; set; }
        public List<User> Receivers { get; set; }
    }

    public class MessageContext : DbContext
    {
        public MessageContext() : base()
        {

        }

        public DbSet<Message> Messages { get; set; }

    }
}