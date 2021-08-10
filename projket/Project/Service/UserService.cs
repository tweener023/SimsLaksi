// File:    UserService.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:56:50 PM
// Purpose: Definition of Class UserService

using System;
using System.Collections.Generic;
using Model;

namespace Service
{
   public class UserService
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
   }
}