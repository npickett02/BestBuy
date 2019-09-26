using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Product();
            game.Name = "PS4";
            game.Price = 299.99;
            Console.WriteLine("Product Name: " + game.Name +  " Price: " +game.Price+ " After Tax: " + game.PriceWithTax());
           
        }

       
    }
}
