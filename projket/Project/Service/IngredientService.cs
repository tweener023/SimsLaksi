// File:    IngredientService.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:56:50 PM
// Purpose: Definition of Class IngredientService

using System;
using System.Collections.Generic;
using Model;
using Repository;

namespace Service
{
   public class IngredientService
   {
        IngredientRepository ingredientRepository = new IngredientRepository();
      public List<Ingredient> GetAll()
      {
         return ingredientRepository.GetAll();
      }
      
      public List<Ingredient> SearchIngredient()
      {
         throw new NotImplementedException();
      }
    
   
   }
}