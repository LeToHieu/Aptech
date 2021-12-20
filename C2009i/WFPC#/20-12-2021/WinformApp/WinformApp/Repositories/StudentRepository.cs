using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
CREATE TABLE Students(
    StudentId INT PRIMARY KEY IDENTITY(1, 1),
    UserName NVARCHAR(100),
    Password NVARCHAR(50)
);
INSERT INTO Students(UserName, Password)
VALUES('hoangnd', '123456');
 */

namespace WinformApp.Repositories
{
    public class StudentRepository
    {
        private Database database = new Database();
        public Boolean login(string userName, string password) {
            try
            {
                using (SqlConnection sqlConnection = database.GetConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(
                        @"SELECT * FROM Students WHERE UserName = @userName AND Password = @password",
                        sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@userName", userName);
                    sqlCommand.Parameters.AddWithValue("@password", password);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        return true;
                    }

                    // Call Close when done reading.
                    return false;
                }
            }
            catch (Exception e) {
                Console.WriteLine("Error login to your account: "+e.ToString());
                return false;
            }
        }
    }
}
