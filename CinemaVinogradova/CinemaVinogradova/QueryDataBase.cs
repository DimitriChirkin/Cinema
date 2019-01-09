using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CinemaVinogradova
{


    public class QueryDataBase
    {
        MySqlConnection connection;
        public QueryDataBase()
        {
            connection = new MySqlConnection(ConnectionString.Connect);
            connection.Open();
        }
        public string[] GetData(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            string result = string.Empty;
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (i < reader.FieldCount - 1)
                        result += reader[i].ToString() + ';';
                    else result += reader[i].ToString();
                }

                result += '|';
            }
            reader.Close();
            if (result.Length > 0)
            {
                result = result.Remove(result.Length - 1, 1);
                return result.Split('|');
            }
            else return null;
        }
        public void InsertData(string query)
        {
          
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            
        }
    }
}




