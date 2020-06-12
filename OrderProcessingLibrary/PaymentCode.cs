using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrary
{
   public class PaymentCode
    {

       public string Value { get; }


        public PaymentCode(string value)
        {
            Value = value;

        }
        //public enum PaymentFor
        //  {
        //      physicalproduct = '1',
        //      membership = '2',
        //      Video ='3'

        //  }

    }
}
