using OrderProcessing.BL.InterfaceRule;

namespace OrderProcessing.BL.ConcreteRule
{
    public class MembershipUpgrade : IPaymentType
    {
        public string DoPayment() => "E-mail the owner and inform them of the activation/upgrade";
    }
}
