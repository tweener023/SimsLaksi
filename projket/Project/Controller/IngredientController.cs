// File:    IngredientController.cs
// Author:  User
// Created: Saturday, June 12, 2021 12:00:17 PM
// Purpose: Definition of Class IngredientController

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

        public List<Ingredient> GetAll()
        {
            return _ingredientService.GetAll();
        }
    }

}