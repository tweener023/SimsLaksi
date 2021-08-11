// File:    IngredientController.cs
// Author:  User
// Created: Saturday, June 12, 2021 12:00:17 PM
// Purpose: Definition of Class IngredientController

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Controller
{
   public class IngredientController
   {
        IngredientService ingredientService = new IngredientService();
      public List<Ingredient> GetAll()
      {
            return ingredientService.GetAll();      }
      
      public List<Ingredient> SearchIngredient()
      {
         throw new NotImplementedException();
      }
   }
}