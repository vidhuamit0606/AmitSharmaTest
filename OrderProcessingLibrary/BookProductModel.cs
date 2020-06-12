using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrary
{
    public class BookProductModel : IProductModel
    {
        public string Title { get; set ; }

        public bool HasOrderBeenCompleted { get; set; }

        public PaymentCode paymentcode { get; set; }

       // public RoyaltyModel royaltymodel  { get; set; }
    Dictionary<PaymentCode, IProductModel> AllpaymentsByKey { get; set; }

        public BookProductModel(string title, string paymentcode)
        {
            this.Title = title;
            this.paymentcode = new PaymentCode(paymentcode);
            //this.royaltymodel = new RoyaltyModel(royaltymodel,"","","");
        }

        public void SlipSlipforShipping(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating Added the { Title } packingSlip to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }

        public void packingSlipforRoyaltyDept(RoyaltyModel royalty)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating Added { Title } packingSlip to { royalty.DepartmentName } in { royalty.City }");
                HasOrderBeenCompleted = true;
            }

        }

        public void generateCommisionforAgent(Agent agent)
        {

            if(paymentcode.Value != string.Empty)
            {
                Console.WriteLine($"Simulating Commision Payment to { agent.AccountNumber } ");
            }
           
        }
    }
}
