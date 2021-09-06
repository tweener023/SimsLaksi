using System;
using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Service;

namespace Controller
{
   public class MedicineController
   {
        // private MedicineService medicineService = new MedicineService();

        private readonly IMedicineService _medicineService;

        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        public List<Medicine> GetAll()
        {
            return _medicineService.GetAll();
        }


        public List<Medicine> GetByValidation(bool validation)
        {
            return _medicineService.GetByValidation(validation);
        }

        public void AcceptMedicine(Medicine medicine)
        {
            _medicineService.AcceptMedicine(medicine);
        }

        public void DeleteMedicine(Medicine medicine)
        {
            _medicineService.DeleteMedicine(medicine);
        }

        public void RejectMedicine(Medicine medicine)
        {
            _medicineService.RejectMedicine(medicine);
        }

        public void CreateMedicine(string code, string name, string manufacturer, float price, int amount, List<Ingredient> ingredients)
        {
            _medicineService.CreateMedicine(code, name, manufacturer, price, amount, ingredients);
        }
    }
}