using Microsoft.Extensions.DependencyInjection;
using OrderProcessing.BL.ConcreteRule;
using OrderProcessing.BL.InterfaceRule;
using OrderProcessing.Client;
using System;
using System.Linq;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessingCreator = new OrderProcessingCreator();
            var serviceObject = orderProcessingCreator.serviceProvider.GetServices<IPaymentType>().ToList();
            var result = serviceObject.First(e=>e.GetType() == typeof(Membership)).DoPayment();
            Console.WriteLine("Payment Rule apply: "+result);
            Console.ReadKey();
        }
    }
}
