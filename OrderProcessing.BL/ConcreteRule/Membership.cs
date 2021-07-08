using OrderProcessing.BL.InterfaceRule;

namespace OrderProcessing.BL.ConcreteRule
{
    public class Membership : IPaymentType
    {
        public string DoPayment() => "Activate membership";
    }
}
