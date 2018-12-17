using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// Has the login attempt failed?
        /// </summary>
        public bool HasFailed
        {
            get;
            set;
        }
        /// <summary>
        /// The name used to attempt the login.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}