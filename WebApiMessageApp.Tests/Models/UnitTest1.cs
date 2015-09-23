using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiMessageApp.Models;
using System.Collections.Generic;

namespace WebApiMessageApp.Tests.Models
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void TestDatabase()
        {
            var sender = new User()
            {
                Id = "User1",
                IsActive = true,
                Name = "Modulus",
                Password = "Secret"
            };

            var receivers = new List<User>();

            receivers.Add(new User()
            {
                Id = "User2",
                IsActive = true,
                Name = "OctopusMasterServer",
                Password = "MasterDeploy"
            });

            var message = new Message()
            {
                Subject = "Urgent",
                Id = "x12j213kljsja1238219312xadn42",
                Sender = sender,
                Receivers = receivers
            };

        }
    }
}
