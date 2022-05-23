using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        class Product
        {
            //public Product(string fruit,double price)
            //{
            //    this.Fruit = fruit;
            //    this.Price = price;
            //}
            public string Fruit { get; set; }
            public double Price { get; set; }

        }

        static void Main(string[] args)
        {
            
            string command = Console.ReadLine();
            var productShop=new Dictionary<string,Dictionary<string,double>>();
            while(command!= "Revision")
            {
                string[] commandArray= command.Split(", ");
                string company= commandArray[0];
                string fruit = commandArray[1];
                double price= double.Parse(commandArray[2]);
                if (productShop.ContainsKey(company))
                {
                    productShop[company][fruit] = price;
                }
                else
                {
                    productShop.Add(company, new Dictionary<string,double>());
                    productShop[company].Add(fruit, price);

                }

                command = Console.ReadLine();
            }

            var orderedDictionary=productShop.OrderBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);

            foreach(var item in orderedDictionary)
            {
                Console.WriteLine($"{item.Key}->");
                foreach(var (product,price) in item.Value)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
