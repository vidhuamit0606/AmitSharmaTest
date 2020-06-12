using System;

namespace OrderProcessingLibrary
{
    public interface IProductModel
    {
        string Title { get; set; }

        bool HasOrderBeenCompleted { get; }

        PaymentCode paymentcode { get; set; }


        void SlipSlipforShipping(CustomerModel customer);

        void generateCommisionforAgent(Agent agent);
    }
}
