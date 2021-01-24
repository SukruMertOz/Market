using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Orange";
            product1.Price = 14;
            product1.stock = 300;
            product1.explanation = "Fresh Orange";


            Product product2 = new Product();
            product2.Name = "Berry";
            product2.Price = 30;
            product2.stock = 150;
            product2.explanation = "Frozed Berry";

            Product product3 = new Product(); 
            product3.Name = "Apple";
            product3.Price = 5;
            product3.stock = 3000;
            product3.explanation = "Imported Apple";

            Product[] products = new Product[] { product1, product2, product3 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.stock);
                Console.WriteLine(product.explanation);
            }
               
        }
    }
}
