using Microsoft.VisualStudio.TestTools.UnitTesting; // MS Test Framework used
using ConsoleApp1;
using Moq;

namespace TestCustomer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddCustomerTest()
        {
            // DELETE THIS CODE AS WE ARE GOING TO USE MOQ
            //Customer obj = new Customer();
            //Assert.AreEqual(obj.AddCustomer(), true);
            Mock<MyEmail> objEmail = new Mock<MyEmail>();

            // specify which function you want to pass, and we are specifying that bypass it and always return true
            objEmail.Setup(m=>m.SendEmail()).Returns(true);

            
            Customer obj = new Customer();
            bool isInserted = obj.AddCustomer(objEmail.Object);
            
            Assert.AreEqual(true, isInserted);
           


        }



    }
}
