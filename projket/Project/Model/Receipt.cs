// File:    Receipt.cs
// Author:  User
// Created: Saturday, June 12, 2021 11:38:03 AM
// Purpose: Definition of Class Receipt

using System;
using System.Collections.Generic;
using Model;

namespace Model
{
   public class Receipt
    {
        public Receipt(int id, string pharmacist, string dateAndTime, Dictionary<string, int> medQty, string medQtyStr, float price, string userJmbg)
        {
            this.Id = id;
            this.Pharmacist = pharmacist;
            this.DateAndTime = dateAndTime;
            this.MedQty = medQty;
            this.MedQtyString = medQtyStr;
            this.Price = price;
            this.UserJmbg = userJmbg;
        }
        public int Id
        {
            get
            ;
            set
            ;
        }

        public String Pharmacist
        {
            get
            ;
            set
            ;
        }
        public String DateAndTime
        {
            get
            ;
            set
            ;
        }
        public Dictionary<string, int> MedQty
        {
            get
            ;
            set
            ;
        }

        public String MedQtyString
        {
            get
            ;
            set
            ;
        }

        public float Price
        {
            get
            ;
            set
            ;
        }
        public String UserJmbg
        {
            get
            ;
            set
            ;
        }
    }
}