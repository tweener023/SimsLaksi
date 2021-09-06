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

        public List<Ingredient> SearchIngredient()
        {
            throw new NotImplementedException();
        }

        public Ingredient UpdateIngredient(Ingredient ingredientToUpdate)
        {
            ReadJson();
            int indeks = _objects.FindIndex(obj => obj.Name == ingredientToUpdate.Name);
            _objects[indeks] = ingredientToUpdate;
            WriteToJson();
            return ingredientToUpdate;
        }

        public Ingredient GetByName(string ingredientName)
        {
            ReadJson();
            return _objects.Find(obj => obj.Name == ingredientName);
        }

        private void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(_objects, Formatting.Indented);
            File.WriteAllText(_fileLocation, json);
        }

        private void ReadJson()
        {
            if (!File.Exists(_fileLocation))
            {
                File.Create(_fileLocation).Close();
            }

            StreamReader streamReader = new StreamReader(_fileLocation);

            string json = streamReader.ReadToEnd();
            if (json != "")
            {
                _objects = JsonConvert.DeserializeObject<List<Ingredient>>(json);
            }
        }

    }
}