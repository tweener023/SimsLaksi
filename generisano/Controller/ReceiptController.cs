// File:    ReceiptController.cs
// Author:  User
// Created: subota, 12. jun 2021. 12:00:20
// Purpose: Definition of Class ReceiptController

using System;

namespace Controller
{
   public class ReceiptController
   {
      public List<Receipt> GetAll(string userJmbg)
      {
         throw new NotImplementedException();
      }
      
      public System.Collections.Generic.List<ReceiptService> receiptService;
      
      /// <summary>
      /// Property for collection of Service.ReceiptService
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<ReceiptService> ReceiptService
      {
         get
         {
            if (receiptService == null)
               receiptService = new System.Collections.Generic.List<ReceiptService>();
            return receiptService;
         }
         set
         {
            RemoveAllReceiptService();
            if (value != null)
            {
               foreach (Service.ReceiptService oReceiptService in value)
                  AddReceiptService(oReceiptService);
            }
         }
      }
      
      /// <summary>
      /// Add a new Service.ReceiptService in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddReceiptService(Service.ReceiptService newReceiptService)
      {
         if (newReceiptService == null)
            return;
         if (this.receiptService == null)
            this.receiptService = new System.Collections.Generic.List<ReceiptService>();
         if (!this.receiptService.Contains(newReceiptService))
            this.receiptService.Add(newReceiptService);
      }
      
      /// <summary>
      /// Remove an existing Service.ReceiptService from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveReceiptService(Service.ReceiptService oldReceiptService)
      {
         if (oldReceiptService == null)
            return;
         if (this.receiptService != null)
            if (this.receiptService.Contains(oldReceiptService))
               this.receiptService.Remove(oldReceiptService);
      }
      
      /// <summary>
      /// Remove all instances of Service.ReceiptService from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllReceiptService()
      {
         if (receiptService != null)
            receiptService.Clear();
      }
   
   }
}