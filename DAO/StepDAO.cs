using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StepDAO : InterfaceDAO<StepDTO>
    {
        private static StepDAO instance;
        public static StepDAO Instance
        {
            get { if (instance == null) instance = new StepDAO(); return instance; }
            private set { instance = value; }
        }
        private StepDAO() { }
        public int Insert(StepDTO step)
        {
            string query = "INSERT INTO [Step] (StepName, IsDone, TaskID) VALUES (@stepName, @isDone, @taskID); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@stepName", SqlDbType.NVarChar) { Value = step.StepName },
                new SqlParameter("@isDone", SqlDbType.Bit) { Value = step.IsDone },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = step.TaskID }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                step.StepID = newId;
                return newId;
            }
            return -1;
        }
        public int Update(StepDTO step)
        {
            string query = "UPDATE [Step] SET StepName = @stepName, IsDone = @isDone, TaskID = @taskID WHERE StepID = @stepID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@stepName", SqlDbType.NVarChar) { Value = step.StepName },
                new SqlParameter("@isDone", SqlDbType.Bit) { Value = step.IsDone },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = step.TaskID },
                new SqlParameter("@stepID", SqlDbType.Int) { Value = step.StepID },
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }
        public int Delete(int stepID)
        {
            string query = "DELETE FROM [Step] WHERE StepID = @stepID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@stepID", SqlDbType.Int) { Value = stepID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }

        public List<StepDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<StepDTO> StepListByTaskID(int taskID)
        {
            List<StepDTO> steps = new List<StepDTO>();

            string query = "SELECT * FROM [Step] WHERE TaskID = @taskID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskID }
            };

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
            {
                // Đọc dữ liệu từ SqlDataReader
                while (reader.Read())
                {
                    // Tạo đối tượng StepDTO và gán giá trị
                    StepDTO step = new StepDTO
                    {
                        StepID = reader.GetInt32(reader.GetOrdinal("StepID")),
                        StepName = reader.GetString(reader.GetOrdinal("StepName")),
                        IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                        TaskID = reader.GetInt32(reader.GetOrdinal("TaskID")),
                    };

                    // Thêm vào danh sách
                    steps.Add(step);
                }
            }

            return steps;
        }

        public StepDTO SelectByID(int t)
        {
            string query = "SELECT * FROM [Step] WHERE StepID = @stepID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@stepID", SqlDbType.Int) { Value = t }
            };

            StepDTO step = null;

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    step = new StepDTO
                    {
                        StepID = reader.GetInt32(reader.GetOrdinal("StepID")),
                        StepName = reader.GetString(reader.GetOrdinal("StepName")),
                        IsDone = reader.GetBoolean(reader.GetOrdinal("IsDone")),
                        TaskID = reader.GetInt32(reader.GetOrdinal("TaskID")),
                    };
                }
            }
            return step;
        }


        public int Delete(StepDTO t)
        {
            throw new NotImplementedException();
        }

        public StepDTO selectedByID(int t)
        {
            throw new NotImplementedException();
        }
    }
}
