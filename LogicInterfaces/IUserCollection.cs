﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IUserCollection
    {
        /// <summary>
        /// A list of IUser interfaces.
        /// </summary>
        List<IUser> Users { get; set; }

        /// <summary>
        /// Fills the Users property with the data belonging to all users and returns true. Returns false if no users are found.
        /// </summary>
        /// <returns></returns>
        bool GetAllUsers();
    }
}
