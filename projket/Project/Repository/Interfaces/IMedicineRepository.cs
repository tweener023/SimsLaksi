using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interfaces
{
    public interface IMedicineRepository
    {
        List<Medicine> GetAll();

        List<Medicine> SearchMedicine();

        List<Medicine> GetByValidation(bool validation);

        void BuyMedicine();

        void CreateMedicine(Medicine medicine);

        Medicine UpdateMedicine(Medicine medToUpdate);
    }
}
