// File:    Ingredient.cs
// Author:  User
// Created: Saturday, June 12, 2021 11:38:03 AM
// Purpose: Definition of Class Ingredient

using System;

namespace Model
{
   public class Ingredient
   {
        public Ingredient(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public String Name
        {
            get
            ;
            set
            ;
        }
        public String Description
        {
            get
            ;
            set
            ;
        }

        public int CountInMedicines
        {
            get
            ;
            set
            ;
        }
    }
}
