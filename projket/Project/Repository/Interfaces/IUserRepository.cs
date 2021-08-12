using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interfaces
{
    public interface IUserRepository
    {
        void RegisterPatient(User user);

        List<User> GetAll();

        List<User> GetAllPatients();

        User GetByJmbg(string jmbg);
    }
}
