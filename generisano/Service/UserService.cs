// File:    UserService.cs
// Author:  Nikolaj Satara
// Created: èetvrtak, 17. jun 2021. 16:56:50
// Purpose: Definition of Class UserService

using System;

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
      
      public System.Collections.Generic.List<UserRepository> userRepository;
   
   }
}