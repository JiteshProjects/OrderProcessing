using Microsoft.Extensions.DependencyInjection;
using OrderProcessing.BL.ConcreteRule;
using OrderProcessing.BL.InterfaceRule;
using System;

namespace OrderProcessing.Client
{
    public class OrderProcessingCreator
    {
        public ServiceProvider serviceProvider { get; }
        public OrderProcessingCreator()
        {
             serviceProvider = new ServiceCollection()
              .AddSingleton<IPaymentType, Membership>()
              .AddSingleton<IPaymentType, UpgradeMembership>()
              .AddSingleton<IPaymentType, MembershipUpgrade>()
              .AddSingleton<IPaymentType, PaymentForBook>()
              .AddSingleton<IPaymentType, PhysicalProduct>()
              .AddSingleton<IPaymentType, PhysicalProductOrBook>()
              .AddSingleton<IPaymentType, VideoLearning>()
              .BuildServiceProvider();
        }
    }
}
