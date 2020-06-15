using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingLibrarytst
{
    public interface IBookProductModel : IProductModel
    {
        void packingSlipforRoyaltyDept(RoyaltyModel royalty);

    }
}
