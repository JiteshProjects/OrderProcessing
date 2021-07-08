using OrderProcessing.BL.InterfaceRule;

namespace OrderProcessing.BL.ConcreteRule
{
    public class PhysicalProduct : IPaymentType
    {
        public string DoPayment() => "Generate a packing slip for shipping";
    }
}
