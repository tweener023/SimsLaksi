// File:    ReceiptController.cs
// Author:  User
// Created: Saturday, June 12, 2021 12:00:20 PM
// Purpose: Definition of Class ReceiptController

using System;
using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Service;

namespace Controller
{
   public class ReceiptController
   {

        private readonly IReceiptService _receiptService;

        public ReceiptController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }

        public void CreateReceipt(Receipt receipt)
        {
            _receiptService.CreateReceipt(receipt);
        }

        public List<Receipt> GetByUserJmbg(string userJmbg)
        {
            return _receiptService.GetByUserJmbg(userJmbg);
        }

    }
}