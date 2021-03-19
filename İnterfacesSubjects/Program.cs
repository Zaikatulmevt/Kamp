using System;

namespace İnterfacesSubjects
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                ID = 2,
                CustomerNo = 11,
                FirstName = "Engin",
                LastName = "Demiroğ"
            };
            personManager.Add(customer);
            personManager.Add(new Customer {ID=1, FirstName="Metehan", LastName= "Yapan", CustomerNo= 12 });

            Console.WriteLine("------------------------------------");

            Student student = new Student
            {
                ID = 2, FirstName = "Fatma", LastName = "Bulut", StudentNumber = 1173
            };
            personManager.Add(student);
        }
    }
    class Customer:IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerNo { get; set; }

    }
    class Student:IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentNumber { get; set; }

    }

    class PersonManager
    {
        //public void Add(Customer customer)
        //{
        //    Console.WriteLine("Added is " + customer.FirstName);
        //}
        //public void Add(Student student)
        //{
        //    Console.WriteLine(student.FirstName + " " +student.LastName + " eklendi");
        //}
        public void Add(IPerson person)
        {
            Console.WriteLine("Added is " + person.FirstName + " " + person.LastName);
        }
    }
}
