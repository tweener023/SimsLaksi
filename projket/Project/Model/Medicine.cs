// File:    Medicine.cs
// Author:  User
// Created: Saturday, June 12, 2021 11:38:03 AM
// Purpose: Definition of Class Medicine

using System;
using System.Collections.Generic;
using Model;

namespace Model
{
   public class Medicine
   {
      private string code;
      private string name;
      private string manufacturer;
      private float price;
      private int amount;
      private List<Ingredient> ingredients;
      private bool accepted;
      private bool deleted;
   
   }
}