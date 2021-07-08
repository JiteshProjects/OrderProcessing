using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.BL.ConcreteRule;
using OrderProcessing.BL.InterfaceRule;
using OrderProcessing.Client;
using System.Collections.Generic;
using System.Linq;

namespace OrderProcessing.Test
{
    [TestClass]
    public class OrderProcessingTest
    {
        public List<IPaymentType> serviceObject { get; private set; }

        [TestInitialize]
        public void Setup()
        {
            var orderProcessingCreator = new OrderProcessingCreator();
            serviceObject = orderProcessingCreator.serviceProvider.GetServices<IPaymentType>().ToList();
        }
        [TestMethod]
        public void Test_PaymentType_PhysicalProduct()
        {
            var expected = "Generate a packing slip for shipping";
            var actual = serviceObject.First(e => e.GetType() == typeof(PhysicalProduct)).DoPayment();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_PaymentType_PaymentForBook()
        {
            var expected = "Create a duplicate packing slip for the royalty department";
            var actual = serviceObject.First(e => e.GetType() == typeof(PaymentForBook)).DoPayment();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_PaymentType_Membership()
        {
            var expected = "Activate membership";
            var actual = serviceObject.First(e => e.GetType() == typeof(Membership)).DoPayment();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PaymentType_UpgradeMembership()
        {
            var expected = "Apply the upgrade";
            var actual = serviceObject.First(e => e.GetType() == typeof(UpgradeMembership)).DoPayment();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_PaymentType_MembershipORUpgrade()
        {
            var expected = "E-mail the owner and inform them of the activation/upgrade";
            var actual = serviceObject.First(e => e.GetType() == typeof(MembershipUpgrade)).DoPayment();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_PaymentType_VideoLearning()
        {
            var expected = "Add a free “First Aid” video to the packing slip (the result of a court decision in 1997)";
            var actual = serviceObject.First(e => e.GetType() == typeof(VideoLearning)).DoPayment();
            Assert.AreEqual(expected,actual);
        }
       
    }
}
