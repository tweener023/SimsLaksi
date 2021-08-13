// File:    MedicineService.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:56:50 PM
// Purpose: Definition of Class MedicineService

using System;
using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Repository;

namespace Service
{
   public class MedicineService:IMedicineService
   {
        MedicineRepository medicineRepository = new MedicineRepository();
        public List<Medicine> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Medicine> SearchMedicine()
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetByValidation(bool validation)
        {
            return medicineRepository.GetByValidation(validation);
        }

        public void AcceptMedicine(Medicine medicine)
        {

            // Medicine med = _objects.Find(obj => obj.Code == medicine.Code);
            medicine.Accepted = true;
            medicineRepository.UpdateMedicine(medicine);
            // medicineRepository.AcceptMedicine(medicine);
        }
        public void RejectMedicine(Medicine medicine)
        {

            medicine.Accepted = false;
            medicine.Deleted = true;
            medicineRepository.UpdateMedicine(medicine);
        }

        public void DeleteMedicine(Medicine medicine)
        {
            // ovo je promenjeno proveri da li radi
            medicine.Deleted = true;
            medicineRepository.UpdateMedicine(medicine);
        }


        public void BuyMedicine()
        {
            // provera da li je amount > od amounta koji dobijamo u racunu

            throw new NotImplementedException();
        }

        public void CreateMedicine(string code, string name, string manufacturer, float price, int amount, List<Ingredient> ingredients)
        {
            Medicine newMedicine = new Medicine(code, name, manufacturer, price, amount, ingredients, false, false);
            medicineRepository.CreateMedicine(newMedicine);
        }
    }
}