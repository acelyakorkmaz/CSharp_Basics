﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            Product product2 = new Product {Id=2, ProductName="Kalem", CategoryId=5, UnitInStock=4, UnitPrice=150  };
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //int, double, bool... değer tip
            // diziler, class, abstract class ....... referans tip

            
            
            
            
            Console.ReadLine();
        }
    }
}
