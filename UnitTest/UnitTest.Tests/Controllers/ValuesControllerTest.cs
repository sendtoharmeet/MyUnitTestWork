using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Controllers;
using DataModel;
using System.Net;

namespace UnitTest.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            ValuesController controller = new ValuesController();

            IEnumerable<string> result = controller.Get();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }
        
        [TestMethod]
        public void PostWithStatus2()
        {
            OrderDetail obj = new OrderDetail()
            {
                Address = "Test Address",
                CardExpiryMonth = 12,
                CardExpiryYear = 2016,
                CardNumber = 123123213,
                CardSecurityCode = 123,
                City = "Chandigarh",
                Email = "test@gmail.com",
                FirstName = "Alec",
                LastName = "T",
                Phone = 52354345,
                ProductId = 23,
                ProductPrice = 500,
                State = "AB"
            };
            
            ValuesController controller = new ValuesController();

            var status = controller.Post(obj);

            Assert.AreEqual(status.StatusCode, HttpStatusCode.OK);
            Assert.AreEqual(status.RequestMessage, 2);
        }
        
        [TestMethod]
        public void PostWithStatus1()
        {
            OrderDetail obj = new OrderDetail()
            {
                Address = "Test Address",
                CardExpiryMonth = 12,
                CardExpiryYear = 2017,
                CardNumber = 123123213,
                CardSecurityCode = 123,
                City = "Chandigarh",
                Email = "test@gmail.com",
                FirstName = "Alec",
                LastName = "T",
                Phone = 52354345,
                ProductId = 23,
                ProductPrice = 500,
                State = "AB"
            };

            ValuesController controller = new ValuesController();

            var status = controller.Post(obj);

            Assert.AreEqual(status.StatusCode, HttpStatusCode.OK);
            Assert.AreEqual(status.RequestMessage, 1);
        }
        
        [TestMethod]
        public void PostWithStatusFieldBlankValue()
        {
            OrderDetail obj = new OrderDetail()
            {
                CardExpiryMonth = 12,
                CardExpiryYear = 2017,
                CardNumber = 123123213,
                CardSecurityCode = 123,
                City = "Chandigarh",
                Email = "test@gmail.com",
                FirstName = "Alec",
                LastName = "T",
                Phone = 52354345,
                ProductId = 23,
                ProductPrice = 500,
            };

            ValuesController controller = new ValuesController();

            var status = controller.Post(obj);

            Assert.AreEqual(status.StatusCode, HttpStatusCode.BadRequest); // 400 request for missing or invalid field
            Assert.IsTrue(status.RequestMessage.Content.ToString().Contains("Address is Required"));
        }

        [TestMethod]
        public void PostWithStatusFieldInvalidValue()
        {
            OrderDetail obj = new OrderDetail()
            {
                Address = "Test Address",
                CardExpiryMonth = 12,
                CardExpiryYear = -2017,
                CardNumber = 123123213,
                CardSecurityCode = 123,
                City = "Chandigarh",
                Email = "testgmailcom",
                FirstName = "Alec",
                LastName = "T",
                Phone = 52354345,
                ProductId = 23,
                ProductPrice = 989,
                State = "AB"
            };

            ValuesController controller = new ValuesController();

            var status = controller.Post(obj);

            Assert.AreEqual(status.StatusCode, HttpStatusCode.BadRequest); // 400 request for missing or invalid field
            Assert.IsTrue(status.RequestMessage.Content.ToString().Contains("Invalid Email Address"));
        }
    }
}
