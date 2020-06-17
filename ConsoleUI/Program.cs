using System;
using System.Collections.Generic;
using OrderProcessingLibrarytst;

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
                try
                {
                    prod.SlipSlipforShipping(customer);
                }
                catch (Exception ex)
                {
                    //// Do some logging
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    //throw new Exception("faced some exception", ex);
                }
                finally
                {
                    //assuming if any database side connection is used in flow
                    Console.WriteLine("Close Database Connection");
                }

                if ((prod is IBookProductModel book && book.paymentcode.Value != string.Empty))
                {

                    try
                    {
                        book.packingSlipforRoyaltyDept(royalty);
                        book.generateCommisionforAgent(agent);
                    }
                    catch (Exception ex)
                    {

                        //// Do some logging
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                        //throw new Exception("faced some exception", ex);
                    }
                }

                try
                {
                    prod.generateCommisionforAgent(agent);
                }
                catch (Exception ex)
                {

                    //// Do some logging
                    //throw new Exception("faced some exception", ex);
                }
            }
            foreach (IMembershipModel member in membershipcart)
            {
                if(member is IMembershipModel mem &&  mem.membershipStatus == "ativated")
                {
                    try
                    {
                        mem.Activate(customer);
                    }
                    catch (Exception ex)
                    {

                        //// Do some logging
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                        //throw new Exception("faced some exception", ex);
                    }
                }
                if(member is IMembershipModel memchk && memchk.membershipStatus == "renewed")
                {
                    try
                    {
                        memchk.Renew(customer);
                    }
                    catch (Exception ex)
                    {

                        //// Do some logging
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                        //throw new Exception("faced some exception", ex);
                    }
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
            try
            {
                
                outputtwo.Add(new MembershipModel("ativated", "2"));
                outputtwo.Add(new MembershipModel("renewed", "2"));

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
               // throw new Exception("faced exception..chk!!",ex);
            }

            return outputtwo;
        }


        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            try
            {
                output.Add(new BookProductModel(".NET Core Start to Finish", "1"));


                output.Add(new PhysicalProductModel { Title = "Hard Drive", paymentcode = new PaymentCode("1") });
                //output.Add(new BookProductModel { Title = ".NET Core Start to Finish", paymentcode = new PaymentCode ("1"),royaltymodel= });
                output.Add(new PhysicalProductModel { Title = "IAmAmithSK T-Shirt", paymentcode = new PaymentCode("1") });
                output.Add(new PhysicalProductModel { Title = "Cosco Football", paymentcode = new PaymentCode("1") });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //throw new Exception("faced exception..chk!!",ex);
            }
            //var dict = output.ToDictionary(x =>x.)

            return output;
        }
    }
}
