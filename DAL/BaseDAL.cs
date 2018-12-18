using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDAL
    {
        /// <summary>
        /// The object used to hold the connection.
        /// </summary>
        private SqlConnection connection = new SqlConnection(connectionString);

        /// <summary>
        /// The connection string to use.
        /// </summary>
        private const string connectionString = "Server = mssql.fhict.local; Database = dbi343405; User Id = dbi343405; Password = Pat5W-icqt;";
        
        public BaseDAL() { }

        /// <summary>
        /// Executes the given query on the database and returns the results. Throws an Exception on error.
        /// </summary>
        /// <param name="query">The SQL query to use.</param>
        /// <returns></returns>
        protected DataTable ReadQuery(string query)
        {
            DataTable returnTable = null;

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                returnTable = new DataTable();
                returnTable.Load(reader);

                connection.Close();
            }
            catch (Exception exc)
            {
                connection.Close();

                throw exc;
            }
            
            return returnTable;
        }

        /// <summary>
        /// Executes the given query on the database and returns the changed columns. Throws an Exception on error.
        /// </summary>
        /// <param name="query">The SQL query to use.</param>
        /// <returns></returns>
        protected int WriteQuery(string query)
        {
            int rowsAffected = -1;

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                rowsAffected = cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception exc)
            {
                connection.Close();

                throw exc;
            }
            
            return rowsAffected;
        }
    }
}
