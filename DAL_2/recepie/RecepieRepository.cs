using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DAL.user;
using Domain.ingredients;
using Domain.Recepies;

namespace DAL.recepie
{
    public class RecepieRepository
    {
        private readonly UserContext userContext = new UserContext();

        //CRUD
        // Create
        public Recepie Create(Recepie recepie)
        {
            userContext.Recepies.AddOrUpdate(recepie);
            userContext.SaveChanges();
            return recepie;
        }
        
        public RecepieInfo saveInfo(RecepieInfo recepieInfo)
        {
            userContext.recepieInfos.Add(recepieInfo);
            userContext.SaveChanges(); 
            
            return recepieInfo;
        }
        
        //Read
        public Recepie GetById(int id)
        {
            return userContext.Recepies.FirstOrDefault(x => x.Id == id) ;
        }

        //Delete
        public Recepie DeleteById(int id)
        {
            var element = GetById(id);
            userContext.Ingredients.RemoveRange(element.Ingredients);
            userContext.Recepies.Remove(element);
            userContext.SaveChanges();
            return element;
        }

        public List<Recepie> GetAllPending()
        {
            return GetAllInStatus(RecepieStatus.Pending);
        }
        
        public List<Recepie> GetAllAccepted()
        {
            return GetAllInStatus(RecepieStatus.Accepted);
        }

        public List<Recepie> search(string name)
        {
            return userContext.Recepies
                .Where(x => x.Name.Contains(name)).ToList();
        }

        private List<Recepie> GetAllInStatus(RecepieStatus recepieStatus)
        {
            return userContext.Recepies.Where(x => x.Status == recepieStatus).ToList();
        }
        
        public ISet<Recepie> getAll()
        {
            return userContext.Recepies.Where(x => x.isActive).ToHashSet();
        }
        
        public bool delete(int id)
        {
            var entity = userContext.Recepies.FirstOrDefault(x => x.Id == id);
            if(entity != null)
            { 
                userContext.Recepies.Remove(entity);
                return true;
            } else
            {
                return false;
            }
        } 
    }
}