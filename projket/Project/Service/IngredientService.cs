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