// File:    IngredientRepository.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:58:15 PM
// Purpose: Definition of Class IngredientRepository

using System;
using System.Collections.Generic;
using System.IO;
using Model;
using Newtonsoft.Json;
using Project.Repository.Interfaces;

namespace Repository
{
   public class IngredientRepository:IIngredientRepository
   {
        string _fileLocation;
        private List<Ingredient> _objects = new List<Ingredient>();


        public IngredientRepository()
        {
            _fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Project\\data\\ingredients.json";
            ReadJson();
        }

        public List<Ingredient> GetAll()
        {
            ReadJson();
            return _objects;
        }

        public Ingredient UpdateIngredient(Ingredient ingredientToUpdate)
        {
            ReadJson();
            int index = _objects.FindIndex(obj => obj.Name == ingredientToUpdate.Name);
            _objects[index] = ingredientToUpdate;
            WriteToJson();
            return ingredientToUpdate;
        }

        public List<Ingredient> SearchIngredient()
        {
            throw new NotImplementedException();
        }

        private void ReadJson()
        {
            if (!File.Exists(_fileLocation))
            {
                File.Create(_fileLocation).Close();
            }

            StreamReader r = new StreamReader(_fileLocation);

            string json = r.ReadToEnd();
            if (json != "")
            {
                _objects = JsonConvert.DeserializeObject<List<Ingredient>>(json);
            }
        }

        private void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(_objects, Formatting.Indented);
            File.WriteAllText(_fileLocation, json);
        }
        public Ingredient GetByName(string ingredientName)
        {
            ReadJson();
            return _objects.Find(obj => obj.Name == ingredientName);
        }
    }
}