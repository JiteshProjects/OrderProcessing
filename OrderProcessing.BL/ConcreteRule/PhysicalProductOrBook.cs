using OrderProcessing.BL.InterfaceRule;

namespace OrderProcessing.BL.ConcreteRule
{
    public class PhysicalProductOrBook : IPaymentType
    {
        public string DoPayment() => "Generate a commission payment to the agent.";
    }
}
