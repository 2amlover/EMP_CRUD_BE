using EMPLOYEES_DETAILS_DATACONTRACTS;
using EMPLOYEES_DETAILS_DATAOBJECTS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
namespace EMPLOYEES_DETAILS_BL
{
    public class employees_details_bl
    {
        public int get_Employees_List(ref get_employee_details_list_ip ip, ref get_employee_details_list_op op, string connectionString)
        {
            string query = "SELECT * FROM tbl_employee_details";

           

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tbl_employees_details details = new tbl_employees_details();
                    details.Id = reader.GetInt64("Id");
                    details.FirstName = reader.GetString("FirstName");
                    details.LastName = reader.GetString("LastName");
                    details.Email = reader.GetString("Email");
                    details.Department = reader.GetString("Department");
                    details.DateOfBirth = DateTime.Parse(reader.GetString("DateOfBirth"));
                    details.Address = reader.GetString("Address");
                    details.PhoneNumber = reader.GetString("PhoneNumber");
                    details.JobTitle = reader.GetString("JobTitle");
                    details.Salary = reader.GetDecimal("Salary");
                    details.EmployeeId = reader.GetInt32("EmployeeId");
                    details.Gender = reader.GetString("Gender");
                    details.HireDate = DateTime.Parse(reader.GetString("HireDate"));
                    op.ml_employees.Add(details);
                }
            }
            connection.Close();
            return 0;
        }


        public int get_Employees_Detail(ref get_employee_detail_ip ip, ref get_employee_detail_op op, string connectionString)
        {
            string query = "SELECT * FROM tbl_employee_details WHERE ID = " + ip.m_ID;


            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tbl_employees_details detials = new tbl_employees_details();
                    op.m_employee.Id = reader.GetInt64("Id");
                    op.m_employee.FirstName = reader.GetString("FirstName");
                    op.m_employee.LastName = reader.GetString("LastName");
                    op.m_employee.Email = reader.GetString("Email");
                    op.m_employee.Department = reader.GetString("Department");
                    op.m_employee.DateOfBirth = DateTime.Parse(reader.GetString("DateOfBirth"));
                    op.m_employee.Address = reader.GetString("Address");
                    op.m_employee.PhoneNumber = reader.GetString("PhoneNumber");
                    op.m_employee.JobTitle = reader.GetString("JobTitle");
                    op.m_employee.Salary = reader.GetDecimal("Salary");
                    op.m_employee.EmployeeId = reader.GetInt32("EmployeeId");
                    op.m_employee.Gender = reader.GetString("Gender");
                    op.m_employee.HireDate = DateTime.Parse(reader.GetString("HireDate"));
                }
            }
            connection.Close();
            return 0;
        }

        public int post_Employees_Details(ref post_employee_detail_ip ip, ref post_employee_detail_op op, string connectionString)
        {
            string query = "INSERT INTO tbl_employee_details (Id, FirstName, LastName, Email, Department, DateOfBirth, Address, PhoneNumber, JobTitle, Salary, EmployeeId, Gender, HireDate) " +
                "VALUES (@Id, @FirstName, @LastName, @Email, @Department, @DateOfBirth, @Address, @PhoneNumber, @JobTitle, @Salary, @EmployeeId, @Gender, @HireDate)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Id", ip.m_employee.Id);
                        command.Parameters.AddWithValue("@FirstName", ip.m_employee.FirstName);
                        command.Parameters.AddWithValue("@LastName", ip.m_employee.LastName);
                        command.Parameters.AddWithValue("@Email", ip.m_employee.Email);
                        command.Parameters.AddWithValue("@Department", ip.m_employee.Department);
                        command.Parameters.AddWithValue("@DateOfBirth", ip.m_employee.DateOfBirth);
                        command.Parameters.AddWithValue("@Address", ip.m_employee.Address);
                        command.Parameters.AddWithValue("@PhoneNumber", ip.m_employee.PhoneNumber);
                        command.Parameters.AddWithValue("@JobTitle", ip.m_employee.JobTitle);
                        command.Parameters.AddWithValue("@Salary", ip.m_employee.Salary);
                        command.Parameters.AddWithValue("@EmployeeId", ip.m_employee.EmployeeId);
                        command.Parameters.AddWithValue("@Gender", ip.m_employee.Gender);
                        command.Parameters.AddWithValue("@HireDate", ip.m_employee.HireDate);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return -1;
                    }
                }
            }

            op.m_employee = ip.m_employee;
            return 0;
        }

        public int put_Employees_Details(ref put_employee_detail_ip ip, ref put_employee_detail_op op, string connectionString)
        {
            string query = "UPDATE tbl_employee_details SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Department = @Department, DateOfBirth = @DateOfBirth, Address = @Address, PhoneNumber = @PhoneNumber, JobTitle = @JobTitle, Salary = @Salary, EmployeeId = @EmployeeId, Gender = @Gender, HireDate = @HireDate WHERE ID = " + ip.m_employee.Id;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Id", ip.m_employee.Id);
                        command.Parameters.AddWithValue("@FirstName", ip.m_employee.FirstName);
                        command.Parameters.AddWithValue("@LastName", ip.m_employee.LastName);
                        command.Parameters.AddWithValue("@Email", ip.m_employee.Email);
                        command.Parameters.AddWithValue("@Department", ip.m_employee.Department);
                        command.Parameters.AddWithValue("@DateOfBirth", ip.m_employee.DateOfBirth);
                        command.Parameters.AddWithValue("@Address", ip.m_employee.Address);
                        command.Parameters.AddWithValue("@PhoneNumber", ip.m_employee.PhoneNumber);
                        command.Parameters.AddWithValue("@JobTitle", ip.m_employee.JobTitle);
                        command.Parameters.AddWithValue("@Salary", ip.m_employee.Salary);
                        command.Parameters.AddWithValue("@EmployeeId", ip.m_employee.EmployeeId);
                        command.Parameters.AddWithValue("@Gender", ip.m_employee.Gender);
                        command.Parameters.AddWithValue("@HireDate", ip.m_employee.HireDate);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return -1;
                    }
                }
            }

            op.m_employee = ip.m_employee;
            return 0;
        }

        public int delete_EmployeeDetails(ref delete_employee_detail_ip ip, ref delete_employee_detail_op op, string connectionString)
        {


            string query = "DELETE FROM tbl_employee_details WHERE ID = " + ip.m_ID;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tbl_employees_details detials = new tbl_employees_details();
                    op.m_employee.Id = reader.GetInt64("Id");
                    op.m_employee.FirstName = reader.GetString("FirstName");
                    op.m_employee.LastName = reader.GetString("LastName");
                    op.m_employee.Email = reader.GetString("Email");
                    op.m_employee.Department = reader.GetString("Department");
                    op.m_employee.DateOfBirth = DateTime.Parse(reader.GetString("DateOfBirth"));
                    op.m_employee.Address = reader.GetString("Address");
                    op.m_employee.PhoneNumber = reader.GetString("PhoneNumber");
                    op.m_employee.JobTitle = reader.GetString("JobTitle");
                    op.m_employee.Salary = reader.GetDecimal("Salary");
                    op.m_employee.EmployeeId = reader.GetInt32("EmployeeId");
                    op.m_employee.Gender = reader.GetString("Gender");
                    op.m_employee.HireDate = DateTime.Parse(reader.GetString("HireDate"));

                }
            }
            connection.Close();
            return 0;
        }


    }
}





