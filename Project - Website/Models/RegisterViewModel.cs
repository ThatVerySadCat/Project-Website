using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project___Website.Models
{
    public class RegisterViewModel
    {
        /// <summary>
        /// Has the register attempt failed?
        /// </summary>
        public bool HasFailed
        {
            get;
            set;
        }
        /// <summary>
        /// The name used to attempt a register.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}