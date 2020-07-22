using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCart.ProductType
{
    public class ProductA : IProductType
    {
       
        public int getPrice()
        {
            return 50;
        }
    }
}
