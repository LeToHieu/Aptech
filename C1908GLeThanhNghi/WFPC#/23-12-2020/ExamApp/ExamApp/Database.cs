using ExamApp.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Database
    {
        private const string CONNECTION_STRING =    @"server=DESKTOP-7PS7HG8\SQLEXPRESS;"+
                                                    @"database=C1908GLeThanhNghi;" +
                                                    @"UID=sa;password=123456";
        private SqlConnection connection;
        private static Database instance;
        private Database() { }
        public static Database GetInstance() {
            if (instance == null) {
                instance = new Database();
            }
            return instance;
        }
        public List<Department> getDepartments()
        {
            List<Department> departments = new List<Department>();
            try
            {
                connection = new SqlConnection(CONNECTION_STRING);
                string query = @"SELECT DepartmentID, DepartmentName FROM Departments";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                DataSet dataSet = new DataSet();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read()) {
                    string departmentName = sqlDataReader[0].ToString();
                    int departmentId = Convert.ToInt32(sqlDataReader[1]);
                    Department department = new Department()
                    {
                        DepartmentName = departmentName,
                        DepartmentId = departmentId
                    };
                    departments.Add(department);
                }
                connection.Close();
                return departments;
            }
            catch (Exception ex) {
                Console.Error.WriteLine($"Connect DB error : {ex.ToString()}");
                return departments;
            }
        }
    }
}
