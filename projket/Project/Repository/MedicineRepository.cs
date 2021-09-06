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

        IngredientRepository ingredientRepository = new IngredientRepository(); //potrebno da bih mogao da apdejtujem count ponavljanja


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
            // za true trazimo da je accepted = true
            // za false trazimo da je accepted = false
            ReadJson();
            return _objects.FindAll(obj => obj.Accepted == validation && obj.Deleted != true);
        }

        public void BuyMedicine()
        {
            throw new NotImplementedException();
        }
 
        public Medicine UpdateMedicine(Medicine medToUpdate)
        {
            int index = _objects.FindIndex(obj => obj.Code == medToUpdate.Code);
            _objects[index] = medToUpdate;
            WriteToJson();
            return medToUpdate;
        }

        public void CreateMedicine(Medicine medicine)
        {
            // kada se lek doda u json, moramo promeniti i ingredients count za svaki od ingredientsa koji se pojavljuje u novounetom leku
            _objects.Add(medicine);
            WriteToJson();
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
                _objects = JsonConvert.DeserializeObject<List<Medicine>>(json);
            }
        }
    }
}