// File:    ReceiptService.cs
// Author:  User
// Purpose: Definition of Class ReceiptService

using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Repository;


namespace Service
{
    public class ReceiptService:IReceiptService
    {
        private ReceiptRepository receiptRepository = new ReceiptRepository();


        public void CreateReceipt(Receipt receipt)
        {
            // receipt.MedQtyString = Med
            // key je ime leka, int je broj koliko puta je on kupljen
            // foreach u dictu, i da zapisujemo u string

            receiptRepository.CreateReceipt(receipt);
        }

        public List<Receipt> GetByUserJmbg(string userJmbg)
        {
            return receiptRepository.GetByUserJmbg(userJmbg);
        }

    }
}