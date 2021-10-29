﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NbgHfrCore.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public virtual List<Renting> Rentings { get; set; }
    }
}
