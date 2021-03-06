﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrarytst
{
    public  class MembershipModel : IMembershipModel
    {
      public  string Membershiptype { get; set; }

       public string membershipID { get; set; }

       public string membershipStatus { get; set; }

        public PaymentCode paymentcode { get; set; }

        public MembershipModel(string membershipstatus, string paymentcode)
        {
            this.membershipStatus = membershipstatus;
            this.paymentcode = new PaymentCode(paymentcode);
        }

        public void Activate(CustomerModel customer)
        {
            if (paymentcode.Value != string.Empty)
            {
                Console.WriteLine($"Simulating Emailing the { membershipStatus } member to { customer.FirstName } in { customer.City }");
               
            }

        }

        public void Renew(CustomerModel customer)
        {
            if (paymentcode.Value != string.Empty)
            {
                Console.WriteLine($"Simulating Emailing the { membershipStatus }  member to { customer.FirstName } in { customer.City }");

            }

        }
       public enum mambershipstatus
        {
            ativated,
            renewed,
            inactive

        }
    }
}
