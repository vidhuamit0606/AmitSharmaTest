using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrary
{
   public class CustomerModel
    {
       public string EmailAddress { get; set; }

       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string PhoneNumber { get; set; }
       public string StreetAddress { get; set; }

        public string City { get; set; }
        public string membershipID { get; set; }

    }
}
