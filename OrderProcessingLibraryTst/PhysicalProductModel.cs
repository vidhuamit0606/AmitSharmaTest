using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrarytst
{
    public class PhysicalProductModel : IProductModel
    {
        //string Title { get; set; }
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public PaymentCode paymentcode { get; set; }

        Dictionary<PaymentCode, IProductModel> AllpaymentsByKey { get; set; }

        public void generateCommisionforAgent(Agent agent)
        {
          if (paymentcode.Value != string.Empty)
                {
                    Console.WriteLine($"Simulating Commision Payment to { agent.AccountNumber } ");
                }

            
        }

        public void SlipSlipforShipping(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating packingSlip { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }

        }
    }
}
