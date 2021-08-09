// File:    MedicineRepository.cs
// Author:  User
// Created: èetvrtak, 17. jun 2021. 16:58:15
// Purpose: Definition of Class MedicineRepository

using System;

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
      
      public void CreateMedicine(string code, string name, string manufacturer, float price, int amount, List<Ingredients> ingredients)
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