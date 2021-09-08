using System;
using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Service;

namespace Controller
{
    public class IngredientController
    {
        // private IngredientService ingredientService = new IngredientService();

        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

  
        public Ingredient GetByName(string ingredientName)
        {
            return _ingredientService.GetByName(ingredientName);
        }
        public List<Ingredient> GetAll()
        {
            return _ingredientService.GetAll();
        }

    }

}