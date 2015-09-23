using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiMessageApp.Models;

namespace DemoApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user1 = new User()
            {
                Id = "User1",
                IsActive = true,
                Name = "Modulus",
                Password = "Secret"
            };

            var user2 = new User()
            {
                Id = "User2",
                IsActive = true,
                Name = "OctopusMasterServer",
                Password = "MasterDeploy"
            };

            var message1 = new Message()
            {
                Subject = "Urgent",
                Id = "x12j213kljsja1238219312xadn42",
                Text = "This is urgent, please answer your phone!",
                Sender = user1,
                Receivers = new List<User>() { user2 }
            };

            var message2 = new Message()
            {
                Subject = "Urgent2",
                Id = "x12j213kljsja1238219312xadn43",
                Text = "Are you there, hello?! Pick up!",
                Sender = user1,
                Receivers = new List<User>() { user2}
            };

            var message3 = new Message()
            {
                Subject = "Re: Urgent2",
                Id = "x12j213kljsja1238219312xadn44",
                Text = "Goddamit, what is it? I am in the middle of my lunch...",
                Sender = user2,
                Receivers = new List<User>() { user1 }
            };



            using (var messageCtx = new MessageContext())
            {
                using(var userCtx = new UserContext())
                {
                    userCtx.Users.Add(user1);
                    userCtx.Users.Add(user2);

                    messageCtx.Messages.Add(message1);
                    messageCtx.Messages.Add(message2);
                    messageCtx.Messages.Add(message3);
                }
            }
        }
    }
}
