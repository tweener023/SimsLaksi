// File:    UserService.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:56:50 PM
// Purpose: Definition of Class UserService

using System;
using System.Collections.Generic;
using Model;
using Repository;

namespace Service
{
   public class UserService
   {
        private UserRepository userRepository = new UserRepository();

        public bool Login(string jmbg, string password)
      {
         throw new NotImplementedException();
      }
      
      public void RegisterPatient(string jmbg, string email, string password, string firstName, string lastName, string phone)
      {
            User newUser = new User(jmbg, email, password, firstName, lastName, phone,0);

            userRepository.RegisterPatient(newUser);
        }
      
      public List<User> GetAllPatients()
      {
            return userRepository.GetAllPatients();
        }
   }
}