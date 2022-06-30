using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using De02.Models;
using System.Data;

namespace De02.Database
{
    public class Database
    {
        private const String CONNECTION_STRING = 
                    "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|\\Database.mdf;" +
                    "Integrated Security=True";
        private static Database _database = null;
        //singleton pattern
        public static Database Instance {
            get => _database != null ? _database : new Database();
        }
        private SqlConnection? Connection { get {
                try
                {
                    SqlConnection connection = new SqlConnection(CONNECTION_STRING);
                    connection.Open();
                    return connection;
                }
                catch (Exception e) {
                    Console.WriteLine($"Cannot connect to DB: {e.ToString()}");
                    Connection.Close();
                    return null;
                }
            } 
        }
        public User? GetUser(String username, String password) {
            try
            {
                SqlDataReader myReader = null;
                String query = "SELECT * FROM tblUser WHERE username=@username AND password=@password";
                SqlCommand myCommand = new SqlCommand(query, this.Connection);
                myCommand.Parameters.AddWithValue("@username", username);
                myCommand.Parameters.AddWithValue("@password", password);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    return new User()
                    {
                        id = Convert.ToInt32(myReader["id"]),
                        username = (String)myReader["username"]
                    };
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot query user.Error: {e.ToString()}");
                return null;
            }
            finally {
                Connection.Close();            
            }
        }
        public DataSet GetStudents() {
            try
            {
                SqlDataReader myReader = null;
                DataSet dataSet = new DataSet();
                String query = "SELECT * FROM tblUser";
                SqlCommand myCommand = new SqlCommand(query, this.Connection);                
                myReader = myCommand.ExecuteReader();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.Connection);
                dataAdapter.Fill(dataSet, "Student list");   
                
                return dataSet;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot query user.Error: {e.ToString()}");
                return null;
            }
            finally
            {
                //Connection.Close();
            }
        } 
    }
}
