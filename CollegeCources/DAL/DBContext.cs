using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
// using Microsoft.Data.SqlClient;
namespace EmployeeClock.DAL
{
    public class DBContext
    {
        private string _connectionString;
        public DBContext()
        {
            _connectionString = GetConnString();
        }

        private static string GetConnString()
        {
            IConfiguration builder = new ConfigurationBuilder()
             .AddJsonFile("secrets.json", optional: true) // Add secrets.json
             .Build();

            string cs = builder["ConnectionString"];
            if (string.IsNullOrEmpty(cs)) throw new Exception("Cannot read conn string from secrets");
            return cs!;
        }

        public static DataTable MakeQuery(string queryStr, SqlParameter[] parameters)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Further error handling
                    }
                }
            }
            return output;
        }

        public static DataTable MakeQuery(string queryStr)
        {
            DataTable output = new DataTable();

            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Handle the exception as needed
                    }
                }
            }

            return output;
        }

        public static int ExecuteNonQuery(string queryStr, SqlParameter[] parameters)
        {
            int affectedRows = 0;
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    try
                    {
                        conn.Open();
                        affectedRows = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Consider more detailed exception handling or logging
                    }
                }
            }
            return affectedRows;
        }

        public static int ExecuteNonQuery(string queryStr)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    try
                    {
                        conn.Open();
                        affectedRows = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Handle the exception as needed
                    }
                }
            }

            return affectedRows;
        }
    }
}