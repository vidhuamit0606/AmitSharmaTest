using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using OrderProcessingLibrary;

namespace ConsoleUI
{
   public class Program
    {
        public static void Main(string[] args)
        {

            List<IProductModel> cart = AddSampleData();
            List<IMembershipModel> membershipcart = AddmemberSampleData();
            CustomerModel customer = GetCustomer();
            Agent agent = GetAgent();
            RoyaltyModel royalty = getroyaltyDepartment();


            foreach (IProductModel prod in cart)
            {
                prod.SlipSlipforShipping(customer);

                if ((prod is IBookProductModel book && book.paymentcode.Value != string.Empty))
                {

                    book.packingSlipforRoyaltyDept(royalty);
                    book.generateCommisionforAgent(agent);
                }

                prod.generateCommisionforAgent(agent);
            }
            foreach (IMembershipModel member in membershipcart)
            {
                if(member is IMembershipModel mem &&  mem.membershipStatus == "ativated")
                {
                    mem.Activate(customer);
                }
                if(member is IMembershipModel memchk && memchk.membershipStatus == "renewed")
                {
                    memchk.Renew(customer);
                }
            }
        }

        private static Agent GetAgent()
        {
            return new Agent
            {
                AccountNumber = "XXXX-XXXX-XXXX-1234",
                EmailAddress = "aa@aa.com",
                FirstName = "Vidhu"
            };
            
        }

        private static RoyaltyModel getroyaltyDepartment()
        {
            return new RoyaltyModel
            {
                DepartmentName = "Royalty1",
                City = "ddd",
                PhoneNumber = "99999999",
                StreetAddress = "asasass"

            };

        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Amith",
                LastName = "Sharma",
                City = "bangalore",
                EmailAddress = "skamitanands@gmail.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IMembershipModel> AddmemberSampleData()
        {
            List<IMembershipModel> outputtwo = new List<IMembershipModel>();
            outputtwo.Add(new MembershipModel("Monthly", "2"));
            outputtwo.Add(new MembershipModel("Renew", "2"));

            return outputtwo;
        }


        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new BookProductModel(".NET Core Start to Finish", "1"));
           

            output.Add(new PhysicalProductModel { Title = "Hard Drive",paymentcode = new PaymentCode("1")});
            //output.Add(new BookProductModel { Title = ".NET Core Start to Finish", paymentcode = new PaymentCode ("1"),royaltymodel= });
            output.Add(new PhysicalProductModel { Title = "IAmAmithSK T-Shirt", paymentcode = new PaymentCode("1")});
            output.Add(new PhysicalProductModel { Title = "Cosco Football" ,paymentcode = new PaymentCode("1") });

            //var dict = output.ToDictionary(x =>x.)

            return output;
        }
    }
}
