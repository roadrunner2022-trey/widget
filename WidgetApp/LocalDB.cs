using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace WidgetApp
{
    class LocalDB {

        /*
            Connection variables
        */

        /* string used to connect local database with relative path using |DataDirectory|*/
        private const string connectionString = ("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|widgetDB.mdf;Integrated Security=True");
        private SqlConnection connection = null;

        /*
           SQL Reading Object
         */
        private SqlDataReader reader = null;

        /*
            Query data
         */
        private SqlCommand command;
        

        public LocalDB()
        {
            /* initialize the connection */
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connection successful");
            }catch(SqlException e)
            {
                Console.WriteLine("Connection was unsuccessful:");
                Console.WriteLine(e.Message);
            }

        }

        public SqlDataReader Select(string queryString)
        {
            this.command = new SqlCommand(queryString, connection);
            this.reader = command.ExecuteReader();
            return reader;
        }



    }
}
