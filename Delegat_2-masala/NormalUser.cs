using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_2_masala
{
    public class NormalUser : IUser
    {
        private decimal totalPrice;

        public string FullName { get; set; }
        public ShoppingCard Card { get; set; } 
        public decimal GetPriceDiscountForUser(decimal totalPrise)
        {
            if (Card.Products.Count > 5)
            {
                return totalPrice * (1 - 0.30M);
            }
            else
            {
                return totalPrice;
            }
        }
    }
}
