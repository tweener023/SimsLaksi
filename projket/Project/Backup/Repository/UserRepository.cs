// File:    UserRepository.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:58:15 PM
// Purpose: Definition of Class UserRepository

using System;
using System.Collections.Generic;
using Model;

namespace Repository
{
   public class UserRepository
   {
      public bool Login(string jmbg, string password)
      {
         throw new NotImplementedException();
      }
      
      public bool RegisterPatient(string jmbg, string email, string password, string firstName, string lastName, string phone)
      {
         throw new NotImplementedException();
      }
      
      public List<User> GetAllPatients()
      {
         throw new NotImplementedException();
      }
      
      public void ReadJson()
      {
         throw new NotImplementedException();
      }
      
      public void WriteJson()
      {
         throw new NotImplementedException();
      }
   
   }
}