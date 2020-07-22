using DiscountCart.ProductType;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCart.DiscountCalculator
{
    public class ActiveDiscount : DiscountCalculator
    {
        public Dictionary<string, int> _activeDiscount = new Dictionary<string, int> { { "3A", 130 }, { "2B", 45 }, { "CD", 30 } };
        private Dictionary<string, int> activeDiscount;
        private Dictionary<string, int> productInfo;
        int discountedPrice=0;
        IProductType prodType;

        public ActiveDiscount(Dictionary<string, int> _productInfo, Dictionary<string, int> _activeDiscount) :
            base(_productInfo, _activeDiscount)
        {
            productInfo = _productInfo;
            activeDiscount = _activeDiscount;
        }
        public override int GetDiscountOnA( int quanDis, int price ,int quantity)
        {
            prodType = new ProductA();
            discountedPrice = (quantity / quanDis) * price + (quantity % quanDis) * prodType.getPrice();
            return discountedPrice;
        }

        public override int GetDiscountOnB(int quanDis, int price, int quantity)
        {
            prodType = new ProductB();
            discountedPrice = (quantity / quanDis) * price + (quantity % quanDis) * prodType.getPrice();
            return discountedPrice;
        }

        public override int GetDiscountOnC(int quanDis, int price, int quantity)
        {
            prodType = new ProductC();
            discountedPrice = (quantity / quanDis) * price + (quantity % quanDis) * prodType.getPrice();
            return discountedPrice;
        }

        public override int GetDiscountOnCD(int quanDis, int price, int quantity)
        {
            IProductType prodTypeC = new ProductC();
            IProductType prodTypeD = new ProductD();
            discountedPrice = (quantity / quanDis) * price + GetDiscountOnC(1, prodTypeC.getPrice(), quantity % quanDis) + GetDiscountOnD(1, prodTypeC.getPrice(), quantity % quanDis);
            return discountedPrice;
        }

        public override int GetDiscountOnD(int quanDis, int price, int quantity)
        {
            prodType = new ProductD();
            discountedPrice = (quantity / quanDis) * price + (quantity % quanDis) * prodType.getPrice();
            return discountedPrice;
        }
    }
}
