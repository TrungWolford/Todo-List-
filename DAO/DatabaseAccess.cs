using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        public static void Close(SqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
    public class DatabaseAccess
    {
        // INSERT, UPDATE, DELETE, lệnh DDL
        public static int ExecuteNonQuery(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                // Mở kết nối
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    sqlCmd.Parameters.AddRange(parameters.ToArray());
                }
                return sqlCmd.ExecuteNonQuery();
            }
        }

        //	Truy vấn trả về một giá trị duy nhất
        public static object ExecuteScalar(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                // Mở kết nối
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    sqlCmd.Parameters.AddRange(parameters.ToArray());
                }
                return sqlCmd.ExecuteScalar();
            }
        }

        //	Đọc nhiều bản ghi từ kết quả truy vấn
        public static SqlDataReader ExecuteReader(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                // Mở kết nối
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand(query, conn);
                {
                    sqlCmd.Parameters.AddRange(parameters.ToArray());
                }
                return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        // Trả về một DataTable
        public static DataTable GetDataTable(string query, List<SqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                // Mở kết nối
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand(query, conn);
                if(parameters != null)
                {
                    sqlCmd.Parameters.AddRange(parameters.ToArray());
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        // Trả về một DataSet
        public static DataSet GetDataSet(string query, List<SqlParameter> parameters = null)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                // Mở kết nối
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    sqlCmd.Parameters.AddRange(parameters.ToArray());
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                adapter.Fill(ds);
            }
            return ds;
        }
        
    }
}
