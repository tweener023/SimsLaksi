using System;
using System.Collections.Generic;
using System.IO;
using Model;
using Newtonsoft.Json;
using Project.Repository.Interfaces;

namespace Repository
{
   public class ReceiptRepository:IReceiptRepository
   {

        string _fileLocation;
        private List<Receipt> _objects = new List<Receipt>();


        public ReceiptRepository()
        {
            _fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Project\\data\\receipts.json";
            ReadJson();
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
                _objects = JsonConvert.DeserializeObject<List<Receipt>>(json);
            }
        }
        public void CreateReceipt(Receipt receipt)
        {
            _objects.Add(receipt);
            WriteToJson();
        }

        private void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(_objects, Formatting.Indented);
            File.WriteAllText(_fileLocation, json);
        }

        public List<Receipt> GetByUserJmbg(string userJmbg)
        {
            ReadJson();
            return _objects.FindAll(obj => obj.UserJmbg == userJmbg);
        }
    }
}