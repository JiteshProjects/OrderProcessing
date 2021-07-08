using OrderProcessing.BL.InterfaceRule;

namespace OrderProcessing.BL.ConcreteRule
{
   public class PaymentForBook : IPaymentType
    {
        public string DoPayment() => "Create a duplicate packing slip for the royalty department";
        
    }
}
