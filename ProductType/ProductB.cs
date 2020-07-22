using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCart.ProductType
{
    public class ProductB: IProductType
    {
        public int getPrice()
        {
            return 30;
        }
    }
}
