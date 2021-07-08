using OrderProcessing.BL.InterfaceRule;

namespace OrderProcessing.BL.ConcreteRule
{
    public class VideoLearning : IPaymentType
    {   
        public string DoPayment() => "Add a free “First Aid” video to the packing slip (the result of a court decision in 1997)";
    }
}
