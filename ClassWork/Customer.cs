using System;
using System.Collections.Generic;
using System.Text;
                     //Encapsulation
namespace ClassWork
{
    class Customer
    {
        //property (özellik)
        public int ID { get; set; }

        //private string _firstName;
        //public string FirstName
        //{
        //    get
        //    {
        //        return "Mrs." + _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;
        //    }
        //}

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CustomerNumber { get; set; }
        public string City  { get; set; }

    }
}
