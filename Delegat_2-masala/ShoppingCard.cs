using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_2_masala
{
    public class ShoppingCard
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public delegate decimal GetDiscountPrice(decimal totalPrice);

        public decimal GetFinalPrice(GetDiscountPrice finalPrice, 
            Func<List<Product>, decimal> calculateTotalPrinse,
            Action<decimal, decimal> printDiscountAmount)
        {
            decimal total = calculateTotalPrinse(Products);
            decimal FinalPrince = finalPrice(total);
            printDiscountAmount(total, FinalPrince);
            
            return FinalPrince;
        }

    }
}
