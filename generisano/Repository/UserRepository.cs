// File:    UserRepository.cs
// Author:  User
// Created: èetvrtak, 17. jun 2021. 16:58:15
// Purpose: Definition of Class UserRepository

using System;

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