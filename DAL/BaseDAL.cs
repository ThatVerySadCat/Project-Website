using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace DAL
{
    public class BaseDAL
    {
        /// <summary>
        /// The object used to hold the connection.
        /// </summary>
        private MySqlConnection connection;

        /// <summary>
        /// The connection string to use.
        /// </summary>
        private const string connectionString = "";

        /// <summary>
        /// Initializes the database connection.
        /// </summary>
        public BaseDAL()
        {
            // Initialize MySQL here
        }

        /// <summary>
        /// Executes the given query on the database and returns the results.
        /// </summary>
        /// <param name="query">The SQL query to use.</param>
        /// <returns></returns>
        protected DataTable ReadQuery(string query) { throw new NotImplementedException(); }

        /// <summary>
        /// Executes the given query on the database and returns the changed columns.
        /// </summary>
        /// <param name="query">The SQL query to use.</param>
        /// <returns></returns>
        protected DataTable WriteQuery(string query) { throw new NotImplementedException(); }
    }
}
