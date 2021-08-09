// File:    UserController.cs
// Author:  Nikoaj Satara
// Purpose: Definition of Class UserController

using System;

namespace Controller
{
   public class UserController
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
      
      public System.Collections.Generic.List<UserService> userService;
   
   }
}