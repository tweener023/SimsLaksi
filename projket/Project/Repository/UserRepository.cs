// File:    UserRepository.cs
// Author:  User
// Purpose: Definition of Class UserRepository

using System;
using System.Collections.Generic;
using System.IO;
using Model;
using Newtonsoft.Json;
using Project.Repository.Interfaces;

namespace Repository
{
   public class UserRepository:IUserRepository
   {
        string _fileLocation;
        private List<User> _objects = new List<User>();

        public UserRepository()
        {
            _fileLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Project\\data\\users.json";
            ReadJson();
        }

        public void RegisterPatient(User user)
        {
            _objects.Add(user);
            WriteToJson();
        }

        public List<User> GetAll()
        {
            ReadJson();
            return _objects;
        }

        public List<User> GetAllPatients()
        {
            ReadJson();
            return _objects.FindAll(obj => obj.UserType == 0);
        }

        public User GetByJmbg(string jmbg)
        {
            ReadJson();
            return _objects.Find(obj => obj.Jmbg == jmbg);
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
                _objects = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }

        private void WriteToJson()
        {
            string json = JsonConvert.SerializeObject(_objects, Formatting.Indented);
            File.WriteAllText(_fileLocation, json);
        }
    }
}