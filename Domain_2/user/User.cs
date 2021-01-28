using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Recepies;

namespace Domain
{
    public class User
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }
        public string Pin { get; set; }
        public UserRole Role { get; set; }
        public UserStatus UserStatus { get; set; }
        
        public ICollection<Recepie> FavoriteRecepies { get; set; }

        // how to generate toString automatically
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(FirstName)}: {FirstName}," +
                $" {nameof(LastName)}: {LastName}" +
                $", {nameof(Role)}: {Role}, {nameof(UserStatus)}: {UserStatus}";
        }
    }
}