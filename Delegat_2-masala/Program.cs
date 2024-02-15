
using Delegat_2_masala;

namespace Karzinka
{
    public class Program
    {
        private static ShoppingCard FillingCard()
        {
            ShoppingCard Card = new ShoppingCard();

            Card.Products.Add(new Product() { Name = "Kuylak", Price = 105.5m });
            Card.Products.Add(new Product() { Name = "Shim", Price = 170.4m });
            Card.Products.Add(new Product() { Name = "Nimcha", Price = 55.5m });
            Card.Products.Add(new Product() { Name = "Kurtka", Price = 857.1m });
            Card.Products.Add(new Product() { Name = "Futbolka", Price = 35.7m });
            Card.Products.Add(new Product() { Name = "Paypoq", Price = 3.5m });
            Card.Products.Add(new Product() { Name = "Krasofka", Price = 598.5m });

            return Card;
        }
        private static decimal CalculateTotalProductPrice(List<Product> products)
        {
            var totalPrice = 0.0M;
            foreach (var product in products) 
            {
                totalPrice += product.Price;
            }
            
            return totalPrice;

            //return products.Sum(p => p.Price);
        }

        private static void PrintTotalDiscountAmount(decimal totalPrice, decimal discountPrice)
        {
            Console.WriteLine($"% amount is: {totalPrice - discountPrice} OFF!");
        }
        public static void Main(string[] args) 
        {
            IUser normalUser = new NormalUser() { FullName = "Ozodbek Nazarbekov"};
            IUser premiumUser = new PremiumUser() { FullName = "Anvar Sanayev" };

            normalUser.Card = FillingCard();
            premiumUser.Card = FillingCard();

            decimal normalUserFinalPrice = normalUser.Card.GetFinalPrice(normalUser.GetPriceDiscountForUser, CalculateTotalProductPrice, PrintTotalDiscountAmount);

            Console.WriteLine($"> {normalUser.FullName} payment: ${normalUserFinalPrice}\n");

            decimal premiumUserFinalPrice = premiumUser.Card.GetFinalPrice(premiumUser.GetPriceDiscountForUser, CalculateTotalProductPrice, PrintTotalDiscountAmount);
            
            Console.WriteLine($"> {premiumUser.FullName} payment: ${premiumUserFinalPrice}\n");
        }
    }
}