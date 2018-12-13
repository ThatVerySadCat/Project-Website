using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class LoginViewModel
    {
        public bool HasLoginFailed
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string Username
        {
            get;
            set;
        }
    }
}