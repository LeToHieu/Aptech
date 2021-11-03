using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Repositories
{
    public class StudentRepository
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            try
            {

                SqlConnection connection = Database.getInstance().GetConnection();
                string sql = @"SELECT * FROM tblStudent;";
                SqlCommand command = new SqlCommand(sql, connection);                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {                    
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader[0]);
                    student.Name = Convert.ToString(reader[1]);
                    student.Gender = Convert.ToString(reader[2]);
                    student.DateOfBirth = Convert.ToDateTime(reader[3]);
                    student.Address = Convert.ToString(reader[4]);
                    student.UserName = Convert.ToString(reader[6]);
                    students.Add(student);
                }
                return students;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
