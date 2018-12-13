using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class LoginRegisterViewModel
    {
        /// <summary>
        /// Has an error occured?
        /// </summary>
        public bool HasError
        {
            get;
            set;
        }
        /// <summary>
        /// The username used to login/register.
        /// </summary>
        public string Username
        {
            get;
            set;
        }
    }
}