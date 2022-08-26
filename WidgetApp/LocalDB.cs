using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;

namespace WidgetApp
{
    class LocalDB {
        /* NOTE: This connects to a AWS RDS database that I setup for the purpose of this app*/

        /*
            Connection variables 
        */
        private const string server = "widgetdb.cegrdzaxwavs.us-east-1.rds.amazonaws.com";
        private const string db = "widgetDB";
        private const string user = "widgetMaster94";
        private const string password = "1W1dg3t43v3r!!";

        string connectionString = "SERVER=" + server + "; DATABASE=" + db + "; UID=" +
            user + "; PASSWORD=" + password + ";";

        /* MySql objects for connection*/
        private MySqlConnection connection;
        private MySqlDataReader reader = null;
        private MySqlCommand command;
        

        public LocalDB()
        {
            /* initialize and test the connection */
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connected to AWS RDS");
            }catch(MySqlException e)
            {
                Console.WriteLine("Connection was unsuccessful:");
                Console.WriteLine(e.Message);
                connection.Close();
            }

        }
            
        /* Database object query functions for external use */
        public List<string> Select(string queryString, int numColumns)
        {
            int rowCount = 0;

            //returns up to 1000 records
            List<string> results = new List<string>();

            try
            {
                this.command = new MySqlCommand(queryString, connection);
                this.reader = command.ExecuteReader();
            }catch(MySqlException e)
            {
                Console.WriteLine("Query Failed");
                Console.WriteLine(e.Message);
            }
        
            //read each row of the results
            while (this.reader.Read())
            {

                string row = "";

                //add all field values to this row
                for (int i = 0; i < numColumns; i++)
                {
                    row += this.reader.GetValue(i);

                    //add space if there is another column to do
                    if (!(i + 1 == numColumns))
                    {
                        row += ",";                        
                    }
                }
                Console.WriteLine(row);
                //add this row of data to the query results
                results.Add(row);
                rowCount++;
            }
            reader.Close();
            return results;
        }

        public int Insert(string query, string name, string type, string subtype, string date, string time)
        {
            /* Use parameter subsitution for query */
            this.command = new MySqlCommand(query, connection);
            this.command.Parameters.AddWithValue("@name", name);
            this.command.Parameters.AddWithValue("@type", type);
            this.command.Parameters.AddWithValue("@subtype", subtype);
            this.command.Parameters.AddWithValue("@date", date);
            this.command.Parameters.AddWithValue("@time", time);
            
            /* Execute query */
            try
            {
                return command.ExecuteNonQuery(); //returns number of rows executed
            }
            catch (MySqlException e) 
            {
                Console.WriteLine("No rows written");
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
