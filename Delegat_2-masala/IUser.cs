using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_2_masala
{
    public interface IUser
    {
         string FullName { get; set; }  
        
        ShoppingCard Card { get; set; }
        decimal GetPriceDiscountForUser(decimal totalPrice);
    }
}
