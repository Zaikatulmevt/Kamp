using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class UserManager : IUserService
    {

        public IUserCheckService _userCheckService;
        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
            public override void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.Add(user);
            }
            else
            {
                throw new Exception("Böyle biri bulunamadı");
            }
        }

        public override void Add2(User user)
        {
            base.Add2(user);
        }

        public override void Delete(User user)
        {
            base.Delete(user);
        }

        public override void Save(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.Save(user);
            }
            else
            {
                throw new Exception("Böyle biri bulunamadı");
            }
        }

        public override void Update(User user)
        {
            base.Update
        }
    }
}
