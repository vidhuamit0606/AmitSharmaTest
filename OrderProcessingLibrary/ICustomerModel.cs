using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrary
{
    public interface ICustomerModel
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string StreetAddress { get; set; }
        string membershipID { get; set; }


    }
}
