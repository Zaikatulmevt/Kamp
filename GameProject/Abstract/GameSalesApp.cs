using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Add(User user)
        {
            Console.WriteLine("Müşteri: " + user.FirstName + " " + user.LastName + " " + "sisteme eklendi.");
        }

        public virtual void Delete(User user)
        {
            Console.WriteLine("Müşteri: " + user.FirstName + " " + user.LastName + " " + "silindi.");
        }

        public virtual void Save(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " " + "Müşteri veri tabanına kaydedildi");
        }

        public virtual void Update(User user)
        {
            Console.WriteLine("Müşteri: " + user.FirstName + " " + user.LastName + " " + "güncellendi.");
        }
    }
}
