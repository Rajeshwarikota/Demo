using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SelfPractise
{
    class TypeoFVariables
    {
        public int Age = 43;
        public string Group = "csharp";
        public static string position = "Mentor";
        public const int Constant = 45;
        public readonly int Batch = 34;
        public void LocalVariable()
        {
            string Name = "Raji";
            Console.WriteLine(Name);
        }

        //public void InstanceVariable()
        //{
        //    Console.WriteLine(Age);
        //    Console.WriteLine(Group);
        //}
        public TypeoFVariables()
        {
            Batch = 87;
            Console.WriteLine(Batch);
        }
        public TypeoFVariables(int Batch)
        {
            this.Batch = Batch;
        }

    }
}

//public class CustomerRepository
//{
//    public static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBFORADONet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
//    public static void AddCustomer(Customer model)
//    {
//        try
//        {
//            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
//            SqlCommand sqlcommand = new SqlCommand("spADDCustomers", sqlConnection);
//            sqlcommand.CommandType = CommandType.StoredProcedure;
//            sqlConnection.Open();
//            sqlcommand.Parameters.AddWithValue("@Name", model.Name);
//            sqlcommand.Parameters.AddWithValue("@Salary", model.Salary);
//            sqlcommand.Parameters.AddWithValue("@City", model.City);

//            int Result = sqlcommand.ExecuteNonQuery();
//            if (Result != 0)
//            {
//                Console.WriteLine("Customer added successfully");
//            }
//            else
//            {
//                Console.WriteLine("Something went wrong");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//    public static void GetAllCustomer()
//    {
//        try
//        {
//            Customer customer = new Customer();
//            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
//            string query = "select * from Customer";
//            SqlCommand cmd = new SqlCommand(query, sqlConnection);
//            sqlConnection.Open();
//            SqlDataReader reader = cmd.ExecuteReader();
//            if (reader.HasRows)
//            {
//                while (reader.Read())
//                {
//                    customer.Name = (reader["Name"] == DBNull.Value ? default : reader["Name"]).ToString();
//                    customer.City = (reader["City"] == DBNull.Value ? default : reader["City"]).ToString();
//                    customer.Salary = (float)Convert.ToDouble(reader["Salary"] == DBNull.Value ? default : reader["Salary"]);
//                    Console.WriteLine(customer.Name + "\n" + customer.City + "\n" + customer.Salary);
//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//    public static void UpdateCustomer(Customer model)
//    {
//        try
//        {
//            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
//            SqlCommand sqlcommand = new SqlCommand("spUPDATECustomers", sqlConnection);
//            sqlcommand.CommandType = CommandType.StoredProcedure;
//            sqlConnection.Open();
//            sqlcommand.Parameters.AddWithValue("@Name", model.Name);
//            sqlcommand.Parameters.AddWithValue("@Salary", model.Salary);

//            int Result = sqlcommand.ExecuteNonQuery();
//            if (Result != 0)
//            {
//                Console.WriteLine("customer updated successfully");
//            }
//            else
//            {
//                Console.WriteLine("Something went wrong");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//    public static void DeleteCustomer(Customer model)
//    {
//        try
//        {
//            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
//            SqlCommand sqlcommand = new SqlCommand("spDELETECustomers", sqlConnection);
//            sqlcommand.CommandType = CommandType.StoredProcedure;
//            sqlConnection.Open();
//            // sqlcommand.Parameters.AddWithValue("@Name", model.Name);
//            sqlcommand.Parameters.AddWithValue("@Salary", model.Salary);

//            int Result = sqlcommand.ExecuteNonQuery();
//            if (Result != 0)
//            {
//                Console.WriteLine("customer salary delete successfully");
//            }
//            else
//            {
//                Console.WriteLine("Something went wrong");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}
