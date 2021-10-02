﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{

    //keep info about users; login and pass
    class AccountData
    {
        //поля класса
        private string username;
        private string password;
        //конструктор
        public AccountData(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        //свойства
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {s
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}