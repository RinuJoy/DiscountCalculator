using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCart.ProductType
{
    public class ProductD: IProductType
    {
        public int getPrice()
        {
            return 15;
        }
    }
}
