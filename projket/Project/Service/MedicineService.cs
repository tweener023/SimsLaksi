// File:    MedicineService.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:56:50 PM
// Purpose: Definition of Class MedicineService

using System;
using System.Collections.Generic;
using Model;
using Repository;

namespace Service
{
   public class MedicineService
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

        public void AcceptMedicine()
      {
         throw new NotImplementedException();
      }
      
      public void DeleteMedicine()
      {
         throw new NotImplementedException();
      }
      
      public void RejectMedicine()
      {
         throw new NotImplementedException();
      }
      
      public void BuyMedicine()
      {
         throw new NotImplementedException();
      }
      
      public void CreateMedicine(string code, string name, string manufacturer, float price, int amount, List<Ingredient> ingredients)
      {
         throw new NotImplementedException();
      }
      
     
   
   }
}