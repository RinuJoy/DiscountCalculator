﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace DiscountCart.DiscountCalculator
{
    public abstract class DiscountCalculator
    {
        private Dictionary<string, int> activeDiscount;
        private Dictionary<string, int> productInfo;

        public DiscountCalculator(Dictionary<string, int> _activeDiscount, Dictionary<string, int> _productInfo)
        {
            productInfo = _productInfo;
            activeDiscount = _activeDiscount;
        }

        public int CalculateAmountDiscount()
        {
            int amount = 0;
            foreach(var item in productInfo)
            {

                switch (item.Key)
                {
                    case "A":
                        foreach(var dis  in activeDiscount)
                        {
                            if(dis.Key.Contains("A"))
                            {
                                char[] keyValue = dis.Key.ToCharArray();
                                amount = GetDiscountOnA(keyValue[0],dis.Value,item.Value);
                                return amount;
                            }
                        }
                       
                        break;
                    case "B":
                        foreach (var dis in activeDiscount)
                        {
                            if (dis.Key.Contains("B"))
                            {
                                char[] keyValue = dis.Key.ToCharArray();
                                amount = GetDiscountOnB(keyValue[0], dis.Value, item.Value);
                                return amount;
                            }
                        }
                        break;
                    case "C":
                        foreach (var dis in activeDiscount)
                        {
                            if (dis.Key.Contains("C"))
                            {
                                char[] keyValue = dis.Key.ToCharArray();
                                amount = GetDiscountOnC(keyValue[0], dis.Value, item.Value);
                                return amount;
                            }
                        }
                        break;
                    case "D":
                        foreach (var dis in activeDiscount)
                        {
                            if (dis.Key.Contains("D"))
                            {
                                char[] keyValue = dis.Key.ToCharArray();
                                amount = GetDiscountOnD(keyValue[0], dis.Value, item.Value);
                                return amount;
                            }
                        }
                        break;
                    case "CD":
                        foreach (var dis in activeDiscount)
                        {
                            if (dis.Key.Contains("CD"))
                            {
                                char[] keyValue = dis.Key.ToCharArray();
                                amount = GetDiscountOnCD(keyValue[0], dis.Value, item.Value);
                                return amount;
                            }
                        }
                        break;
                }
            }

            return amount;
        }

        public abstract int GetDiscountOnA(int quanDis, int price, int quantity);
        public abstract int GetDiscountOnB(int quanDis, int price, int quantity);
        public abstract int GetDiscountOnC(int quanDis, int price, int quantity);
        public abstract int GetDiscountOnD(int quanDis, int price, int quantity);
        public abstract int GetDiscountOnCD(int quanDis, int price, int quantity);
    }
}
