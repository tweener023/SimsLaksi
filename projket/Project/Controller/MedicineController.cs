// File:    MedicineController.cs
// Author:  User
// Created: Saturday, June 12, 2021 11:51:07 AM
// Purpose: Definition of Class MedicineController

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Controller
{
   public class MedicineController
   {
        MedicineService medicineService = new MedicineService();
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
            return medicineService.GetByValidation(validation);

        }

        public void AcceptMedicine(Medicine medicine)
      {
            medicineService.AcceptMedicine(medicine);
        }

        public void DeleteMedicine(Medicine medicine)
      {
            medicineService.DeleteMedicine(medicine);
        }

        public void RejectMedicine(Medicine medicine)
      {
            medicineService.RejectMedicine(medicine);
        }

        public void BuyMedicine()
      {
         throw new NotImplementedException();
      }
      
      public void CreateMedicine(string code, string name, string manufacturer, float price, int amount, List<Ingredient> ingredients)
      {
            medicineService.CreateMedicine(code, name, manufacturer, price, amount, ingredients);
        }



    }
}