using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.productName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsİnStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsİnStock = 5, productName = "Kalem", UnitPrice = 35,};

            //PascalCase   //camelCase
            //Referans tipinin heap üzerinde oluşabilmesi için new şeklinde kodlamak gerekir.
            //Stack                         //heap

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
