// File:    MedicineRepository.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:58:15 PM
// Purpose: Definition of Class MedicineRepository

using System;
using System.Collections.Generic;
using System.IO;
using Model;
using Newtonsoft.Json;
using Project.Repository.Interfaces;

namespace Repository
{
   public class MedicineRepository:IMedicineRepository
   {
        string _fileLocation;
        private List<Medicine> _objects = new List<Medicine>();

        IngredientRepository ingredientRepository = new IngredientRepository(); // treba mi da bih mogao da updateujem count pojavljivanja


        public MedicineRepository()
        {
            _fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Project\\data\\medicines.json";
            ReadJson();
        }

        public List<Medicine> GetAll()
        {
            return _objects;
        }
      
        public List<Medicine> SearchMedicine()
        {
            throw new NotImplementedException();
        }
      
        public List<Medicine> GetByValidation(bool validation)
        {
            // true = trazimo uslov accepted = true
            // false = trazimo uslov accepted = false

            ReadJson();
            return _objects.FindAll(obj => obj.Accepted == validation && obj.Deleted != true);
        }

        public void BuyMedicine()
        {
            throw new NotImplementedException();
        }
      
        public void CreateMedicine(Medicine medicine)
        {
            // kada se lek doda u json, moramo promeniti i ingredients count za svaki od ingredientsa koji se pojavljuje u novounetom leku
            _objects.Add(medicine);
            WriteToJson();

            // ovo proveri da li je dobro
            // ovo da bude u servisu
         

        }

        public Medicine UpdateMedicine(Medicine medToUpdate)
        {
            // ReadJson();
            int index = _objects.FindIndex(obj => obj.Code == medToUpdate.Code);
            _objects[index] = medToUpdate;
            WriteToJson();
            return medToUpdate;
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
                _objects = JsonConvert.DeserializeObject<List<Medicine>>(json);
            }
        }

        private void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(_objects, Formatting.Indented);
            File.WriteAllText(_fileLocation, json);
        }
    }
}