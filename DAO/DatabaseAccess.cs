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
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
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
        // Thực thi các lệnh không trả về kết quả, chẳng hạn như: INSERT, UPDATE, DELETE, hoặc lệnh DDL (Data Definition Language).
        // Trả về số dòng bị ảnh hưởng bởi lệnh SQL.
        public static int ExecuteNonQuery(string query, List<SqlParameter> parameters = null)
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

        // Thường được sử dụng với các lệnh như SELECT COUNT(*), SELECT MAX(...), hoặc truy vấn để lấy một giá trị đơn lẻ.
        // Thực thi các lệnh SQL trả về một giá trị duy nhất từ cột đầu tiên của dòng đầu tiên trong kết quả.
        public static object ExecuteScalar(string query, List<SqlParameter> parameters = null)
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

        // Sử dụng để duyệt qua kết quả truy vấn theo từng dòng, phù hợp với các lệnh SELECT.
        // Lưu ý: Kết nối phải được mở trong suốt quá trình đọc và sẽ được đóng khi DataReader kết thúc (CommandBehavior.CloseConnection).
        // Thực thi lệnh SQL trả về nhiều dòng dữ liệu (DataReader).
        public static SqlDataReader ExecuteReader(string query, List<SqlParameter> parameters = null)
        {
            SqlConnection conn = SqlConnectionData.Connect(); 
            conn.Open(); // Mở kết nối

            SqlCommand sqlCmd = new SqlCommand(query, conn);

            if (parameters != null)
            {
                sqlCmd.Parameters.AddRange(parameters.ToArray());
            }

            return sqlCmd.ExecuteReader();
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
