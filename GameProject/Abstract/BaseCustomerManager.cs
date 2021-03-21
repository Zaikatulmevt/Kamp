using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCustomerManager : IUserService
    {
        public void Add(User user)
        {
            Console.WriteLine("Oyuncu " +user.FirstName + " " + user.LastName + " " + "sisteme eklendi");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Oyuncu " + user.FirstName + " " + user.LastName + " " + "sistemden silindi");
        }

        public void Save(User user)
        {
            Console.WriteLine("Oyuncu " + user.FirstName + " " + user.LastName + " " + "veri tabanına kaydedildi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Oyuncu " + user.FirstName + " " + user.LastName + " " + "Güncellendi");
        }
    }
}
