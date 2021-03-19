using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            customerManager.update();

            ProductManager productManager = new ProductManager();

            productManager.add();
            productManager.update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Mete";
            customer.Surname = "Yapan";

            Customer customer2 = new Customer
            {
                ID = 2,
                City = "İstanbul",
                FirstName = "Derin",
                Surname = "Demiroğ",
                CustomerNumber = "2313132"
            };

            Console.WriteLine(customer2.FirstName);

            Console.WriteLine(customer.City);

            


        }
        class CustomerManager
        {
            public void add()
            {
                Console.WriteLine("Customer Added");
            }

            public void update()
            {
                Console.WriteLine("Customer Updated");
            }
        }

        class ProductManager
        {
            public void add()
            {
                Console.WriteLine("Product Added");
            }

            public void update()
            {
                Console.WriteLine("Product Updated");
            }
        }
    }
}
