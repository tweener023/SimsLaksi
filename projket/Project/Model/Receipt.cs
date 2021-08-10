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
      private int code;
      private string pharmacist;
      private string dateAndTime;
      private Dictionary<string, int> medQty;
      private float price;
   
   }
}