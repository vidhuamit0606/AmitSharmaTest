using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrary
{
    public interface IBookProductModel : IProductModel
    {
        void packingSlipforRoyaltyDept(RoyaltyModel royalty);

    }
}
