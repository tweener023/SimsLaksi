// File:    Receipt.cs
// Author:  User
// Created: subota, 12. jun 2021. 11:38:03
// Purpose: Definition of Class Receipt

using System;

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