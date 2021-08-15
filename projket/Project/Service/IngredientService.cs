// File:    IngredientService.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:56:50 PM
// Purpose: Definition of Class IngredientService

using System;
using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Repository;

namespace Service
{
   public class IngredientService:IIngredientService
   {
        IngredientRepository ingredientRepository = new IngredientRepository();

        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public List<Ingredient> GetAll()
        {
         return ingredientRepository.GetAll();
        }
      
      public List<Ingredient> SearchIngredient()
      {
         throw new NotImplementedException();
      }

        public Ingredient GetByName(string ingredientName)
        {
            return _ingredientRepository.GetByName(ingredientName);
        }

    }
}