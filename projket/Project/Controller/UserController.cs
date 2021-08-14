// File:    UserController.cs
// Author:  User
// Created: Saturday, June 12, 2021 11:40:09 AM
// Purpose: Definition of Class UserController

using System;
using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Service;

namespace Controller
{
   public class UserController
   {

        // private UserService userService = new UserService();
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public bool Login(string jmbg, string password)
        {
            throw new NotImplementedException();
        }

        public void RegisterPatient(string jmbg, string email, string password, string firstName, string lastName, string phone)
        {
            _userService.RegisterPatient(jmbg, email, password, firstName, lastName, phone);
        }

        public List<User> GetAllPatients()
        {
            return _userService.GetAllPatients();
        }

        public User GetByJmbg(string jmbg)
        {
            return _userService.GetByJmbg(jmbg);
        }
    }
}