using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IUserService
    {
        void Save(User user);
        void Add(User user);
        void Delete(User user);
        void Update(User user);
    }
}
