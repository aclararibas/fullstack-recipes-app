using DAL.user;
using Domain;
using Domain.Recepies;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_2.user
{
    class UserInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            base.Seed(context);

            context.Users.Add(new User()
            {
                Id = 1,
                FavoriteRecepies = new HashSet<Recepie>(),
                Name = "admin",
                Pass = "admin",
                Pin = "1234",
                Role = UserRole.Admin,
                UserStatus = UserStatus.Accepted
            });
            context.SaveChanges();
        }
    }
}
