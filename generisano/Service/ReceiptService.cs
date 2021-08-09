// File:    ReceiptService.cs
// Author:  User
// Created: èetvrtak, 17. jun 2021. 16:56:50
// Purpose: Definition of Class ReceiptService

using System;

namespace Service
{
   public class ReceiptService
   {
      public List<Receipt> GetAll(string userJmbg)
      {
         throw new NotImplementedException();
      }
      
      public System.Collections.Generic.List<ReceiptRepository> receiptRepository;
      
      /// <summary>
      /// Property for collection of Repository.ReceiptRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<ReceiptRepository> ReceiptRepository
      {
         get
         {
            if (receiptRepository == null)
               receiptRepository = new System.Collections.Generic.List<ReceiptRepository>();
            return receiptRepository;
         }
         set
         {
            RemoveAllReceiptRepository();
            if (value != null)
            {
               foreach (Repository.ReceiptRepository oReceiptRepository in value)
                  AddReceiptRepository(oReceiptRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Repository.ReceiptRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddReceiptRepository(Repository.ReceiptRepository newReceiptRepository)
      {
         if (newReceiptRepository == null)
            return;
         if (this.receiptRepository == null)
            this.receiptRepository = new System.Collections.Generic.List<ReceiptRepository>();
         if (!this.receiptRepository.Contains(newReceiptRepository))
            this.receiptRepository.Add(newReceiptRepository);
      }
      
      /// <summary>
      /// Remove an existing Repository.ReceiptRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveReceiptRepository(Repository.ReceiptRepository oldReceiptRepository)
      {
         if (oldReceiptRepository == null)
            return;
         if (this.receiptRepository != null)
            if (this.receiptRepository.Contains(oldReceiptRepository))
               this.receiptRepository.Remove(oldReceiptRepository);
      }
      
      /// <summary>
      /// Remove all instances of Repository.ReceiptRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllReceiptRepository()
      {
         if (receiptRepository != null)
            receiptRepository.Clear();
      }
   
   }
}