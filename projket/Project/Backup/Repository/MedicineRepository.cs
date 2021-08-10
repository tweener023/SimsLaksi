// File:    MedicineRepository.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:58:15 PM
// Purpose: Definition of Class MedicineRepository

using System;
using System.Collections.Generic;
using Model;

namespace Repository
{
   public class MedicineRepository
   {
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
         throw new NotImplementedException();
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
      
      public void ReadJson()
      {
         throw new NotImplementedException();
      }
      
      public void WriteJson()
      {
         throw new NotImplementedException();
      }
   
   }
}