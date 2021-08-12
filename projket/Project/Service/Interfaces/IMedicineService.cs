using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interfaces
{
    interface IMedicineService
    {
        List<Medicine> GetAll();
        List<Medicine> GetByValidation(bool validation);
        void AcceptMedicine(Medicine medicine);
        void RejectMedicine(Medicine medicine);
        void DeleteMedicine(Medicine medicine);
        void CreateMedicine(string code, string name, string manufacturer, float price, int amount, List<Ingredient> ingredients);
    }
}
