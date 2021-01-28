using DAL_2.user;
using Domain;
using Domain.ingredients;
using Domain.Recepies;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.user
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Recepie> Recepies { set; get; }
        public DbSet<RecepieInfo> recepieInfos { set; get; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public UserContext() : base("name=UserContext")
        {
            Database.SetInitializer(new UserInitializer());
        }

    }
}
