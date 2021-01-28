using System.Collections.Generic;
using System.Linq;
using DAL.recepie;
using Domain;
using Domain.Recepies;

namespace Client.ingredients
{
    public class RecepiesServices
    {
        private RecepieRepository _repository = new RecepieRepository();
        
        public Recepie GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Recepie DeleteById(int id)
        {
            return _repository.DeleteById(id);
        }

        public ISet<Recepie> GetAll()
        {
            return _repository.getAll();
        }

        public List<Recepie> recepiesByUser(User user)
        {
            return _repository.getAll()
                .Where(x => x.CreatedBy.Name == user.Name)
                .ToList();
        }

        public RecepieInfo saveInfo(RecepieInfo recepieInfo)
        {
            return _repository.saveInfo(recepieInfo);
        }

        public List<Recepie> GetAllPending()
        {
            return _repository.GetAllPending();
        }
        
        public List<Recepie> GetAllAccepted()
        {
            return _repository.GetAllAccepted();
        }

        public List<Recepie> search(string search)
        {
            return _repository.search(search);
        }

        public void Create(Recepie recepie) {
            _repository.Create(recepie);
        }
        
        public void ChangeStatus(Recepie recepie, RecepieStatus recepieStatus)
        {
            recepie.Status = recepieStatus;
            _repository.Create(recepie);
        }
    }
}