// File:    UserService.cs
// Author:  User
// Created: Thursday, June 17, 2021 4:56:50 PM
// Purpose: Definition of Class UserService

using System;
using System.Collections.Generic;
using Model;
using Project.Repository.Interfaces;
using Repository;

namespace Service
{
   public class UserService:IUserService
   {
        // private UserRepository userRepository = new UserRepository();

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterPatient(string jmbg, string email, string password, string firstName, string lastName, string phone)
        {
            User newUser = new User(jmbg, email, password, firstName, lastName, phone, 0);

            _userRepository.RegisterPatient(newUser);

        }

        public User GetByJmbg(string jmbg)
        {
            return _userRepository.GetByJmbg(jmbg);
        }

        public List<User> GetAllPatients()
        {
            return _userRepository.GetAllPatients();
        }

    }
}