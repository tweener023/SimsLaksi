using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interfaces
{
   public interface IUserService
    {
        void RegisterPatient(string jmbg, string email, string password, string firstName, string lastName, string phone);
        User GetByJmbg(string jmbg);
        List<User> GetAllPatients();
    }
}
