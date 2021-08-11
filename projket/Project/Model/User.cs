// File:    User.cs
// Author:  User
// Created: Saturday, June 12, 2021 11:38:03 AM
// Purpose: Definition of Class User

using System;

namespace Model
{
   public class User
    {
        public User(string jmbg, string email, string password, string firstName, string lastName, string phone, UserType userType)
        {
            this.Jmbg = jmbg;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.UserType = userType;
        }


        public String Jmbg
        {
            get
            ;
            set
            ;
        }
        public String Email
        {
            get
            ;
            set
            ;
        }
        public String Password
        {
            get
            ;
            set
            ;
        }

        public String FirstName
        {
            get
            ;
            set
            ;
        }

        public String LastName
        {
            get
            ;
            set
            ;
        }

        public String Phone
        {
            get
            ;
            set
            ;
        }

        public UserType UserType
        {
            get
            ;
            set
            ;
        }
    }

}