﻿using ExamApp.models;
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
                    int departmentId = Convert.ToInt32(sqlDataReader[0]);
                    string departmentName = sqlDataReader[1].ToString();
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
        public List<Employee> getEmployees(int departmentId)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                connection = new SqlConnection(CONNECTION_STRING);
                string query = @"SELECT EmployeeID, EmployeeName, DepartmentID, Gender, BirthDate, Telephone, Address FROM Employees";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                DataSet dataSet = new DataSet();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    int employeeID = Convert.ToInt32(sqlDataReader[0]);
                    string employeeName = sqlDataReader[1].ToString();
                    int departmentID = Convert.ToInt32(sqlDataReader[2]);
                    int gender = Convert.ToInt32(sqlDataReader[3]);
                    DateTime birthDate = Convert.ToDateTime(sqlDataReader[4])
                    string telephone = sqlDataReader[5].ToString();
                    string address = sqlDataReader[6].ToString();
                    
                    Employee employee = new Employee()
                    {
                        EmployeeID = employeeID,
                        EmployeeName = employeeName,                        
                        DepartmentId = departmentId,
                        Gender = gender,
                        BirthDate = birthDate,
                        Telephone = telephone,
                        Address = address
                    };
                    employees.Add(employee);
                }
                connection.Close();
                return employees;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Cannot getEmployees error : {ex.ToString()}");
                return employees;
            }
        }
    }
}
