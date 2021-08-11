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
        public Medicine(string code, string name, string manufacturer, float price, int amount, List<Ingredient> ingredients, bool accepted, bool deleted)
        {
            this.Code = code;
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Amount = amount;
            this.Ingredients = ingredients;
            this.Accepted = accepted;
            this.Deleted = deleted;
        }

        public String Code
        {
            get
            ;
            set
            ;
        }
        public String Name
        {
            get
            ;
            set
            ;
        }
        public String Manufacturer
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
        public int Amount
        {
            get
            ;
            set
            ;
        }
        public List<Ingredient> Ingredients
        {
            get
            ;
            set
            ;
        }
        public bool Accepted
        {
            get
            ;
            set
            ;
        }
        public bool Deleted
        {
            get
            ;
            set
            ;
        }

    }
}