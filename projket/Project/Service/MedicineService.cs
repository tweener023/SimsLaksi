using System;
using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Repository;

namespace Service
{
   public class MedicineService:IMedicineService
    {
        // MedicineRepository medicineRepository = new MedicineRepository();

        private readonly IMedicineRepository _medicineRepository;

        public MedicineService(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }

        public List<Medicine> GetAll()
        {
            return _medicineRepository.GetAll();
        }


        public List<Medicine> GetByValidation(bool validation)
        {
            return _medicineRepository.GetByValidation(validation);
        }

        public void AcceptMedicine(Medicine medicine)
        {

            // Medicine med = _objects.Find(obj => obj.Code == medicine.Code);
            medicine.Accepted = true;
            _medicineRepository.UpdateMedicine(medicine);
            // medicineRepository.AcceptMedicine(medicine);
        }
        public void RejectMedicine(Medicine medicine)
        {

            medicine.Accepted = false;
            medicine.Deleted = true;
            _medicineRepository.UpdateMedicine(medicine);
        }

        public void DeleteMedicine(Medicine medicine)
        {
            // ovo je promenjeno proveri da li radi
            medicine.Deleted = true;
            _medicineRepository.UpdateMedicine(medicine);
        }


        public void BuyMedicine()
        {
            // provera da li je amount > od amounta koji dobijamo u racunu

            throw new NotImplementedException();
        }

        public void CreateMedicine(string code, string name, string manufacturer, float price, int amount, List<Ingredient> ingredients)
        {
            Medicine newMedicine = new Medicine(code, name, manufacturer, price, amount, ingredients, false, false);
            _medicineRepository.CreateMedicine(newMedicine);
        }
    }
}