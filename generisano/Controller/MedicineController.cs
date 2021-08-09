// File:    MedicineController.cs
// Author:  Nikolaj Satara
// Created: subota, 12. jun 2021. 11:51:07
// Purpose: Definition of Class MedicineController

using System;

namespace Controller
{
   public class MedicineController
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
      
      public System.Collections.Generic.List<MedicineService> medicineService;
   
   }
}