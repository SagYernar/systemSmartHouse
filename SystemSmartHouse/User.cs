﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSmartHouse
{
    public class User : IUser
    {
        public string Password { get; set; }
        public string SUPassword { get; set ; }

        public User() {
            Password = "Bill Gates";
            SUPassword = "adminqwerty123";
        }
  
    }
}
