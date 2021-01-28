using System;
using System.Collections.Generic;
using System.Linq;
using DAL.ingredients;
using Domain;
using Domain.ingredients;

namespace Client.ingredients
{
    public class UserService
    {
        private UserRespository _repository = new UserRespository();
        
        public User GetByUserName(String username)
        {
            return _repository.GetById(username);
        }

        public User GetByPin(String pin)
        {
            return _repository.GetByPin(pin);
        }


        public List<User> getAll()
        {
            return _repository.getAll().ToList();
        }
        
        public void Create(User user) {
            _repository.Create(user);
        }
        
        public void ChangeStatus(User user, UserStatus userStatus)
        {
            user.UserStatus = userStatus;
            _repository.Create(user);
        }
    }
}