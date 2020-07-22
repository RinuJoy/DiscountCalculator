using DiscountCart.DiscountCalculator;
using System;
using System.Collections.Generic;

namespace DiscountCart
{
    class Program
    {
        static void Main(string[] args)
        {
            //int amount = 0;
             Dictionary<string, int> prod =new Dictionary<string, int> { { "A", 3 }, { "B", 4 }, { "C", 3 }, { "D", 2 } };
             Dictionary<string, int> _activeDiscount = new Dictionary<string, int> { { "3A", 130 }, { "2B", 45 }, { "CD", 30 } };
             ActiveDiscount disc = new ActiveDiscount(prod, _activeDiscount);
             Console.WriteLine(disc.CalculateAmountDiscount());
    }
    }
}
