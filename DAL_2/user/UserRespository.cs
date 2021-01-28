using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Policy;
using DAL.user;
using Domain;
using Domain.Recepies;

namespace DAL.ingredients
{
    public class UserRespository
    {
        private readonly UserContext context = new UserContext();

        public UserRespository()
        {
           
        }

        //CRUD
        // Create
        public User Create(User user)
        {
            context.Users.AddOrUpdate(user);
            context.SaveChanges();

            return user;
        }
        
        //Read
        public User GetById(string id)
        {

            return context.Users
                .Where(x => x.UserStatus != UserStatus.Rejected)
                .FirstOrDefault(x => x.Name == id);
        }

        public User GetByPin(string pin)
        {

            return context.Users
                .Where(x => x.UserStatus != UserStatus.Rejected)
                .FirstOrDefault(x => x.Pin == pin);
        }


        public ISet<User> getAll()
        {
            return context.Users.ToHashSet();
        }
    
    }
}