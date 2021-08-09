// File:    Medicine.cs
// Author:  User
// Created: subota, 12. jun 2021. 11:38:03
// Purpose: Definition of Class Medicine

using System;

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