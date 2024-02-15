using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_2_masala
{
    public class PremiumUser : IUser
    {
        public string FullName {  get; set; }
        public ShoppingCard Card {  get; set; }

        public decimal GetPriceDiscountForUser(decimal totalPrice)
        {
            return totalPrice * (1 - 0.30M);
        }
    }
}
