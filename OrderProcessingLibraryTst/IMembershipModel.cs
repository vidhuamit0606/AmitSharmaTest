using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrarytst
{
    public interface IMembershipModel
    {
        string Membershiptype { get; set; }

        string membershipID { get; set; }

        string membershipStatus { get; set; }

        void Activate(CustomerModel customer);

        void Renew(CustomerModel customer);


    }
}
