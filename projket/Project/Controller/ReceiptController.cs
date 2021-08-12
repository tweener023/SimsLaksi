// File:    ReceiptController.cs
// Author:  User
// Created: Saturday, June 12, 2021 12:00:20 PM
// Purpose: Definition of Class ReceiptController

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Controller
{
   public class ReceiptController
   {
        private ReceiptService receiptService = new ReceiptService();

        public List<Receipt> GetAll(string userJmbg)
        {
         throw new NotImplementedException();
        }

        public List<Receipt> GetByUserJmbg(string userJmbg)
        {
            return receiptService.GetByUserJmbg(userJmbg);
        }


        public void CreateReceipt(Receipt receipt)
        {
            receiptService.CreateReceipt(receipt);
        }
    }
}