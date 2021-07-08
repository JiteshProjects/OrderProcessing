using OrderProcessing.BL.InterfaceRule;

namespace OrderProcessing.BL.ConcreteRule
{
    public class UpgradeMembership : IPaymentType
    {
        public string DoPayment() => "Apply the upgrade";
    }
}
