using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StepBUS
    {
        StepDAO stepDAO = StepDAO.Instance;
        public StepBUS() { }

        public int Insert(StepDTO step)
        {
            return stepDAO.Insert(step);
        }
        public int Update(StepDTO step)
        {
            return stepDAO.Update(step);
        }
        public int Delete(int stepID)
        {
            return stepDAO.Delete(stepID);
        }

        public List<StepDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<StepDTO> StepListByTaskID(int taskID)
        {
            return stepDAO.StepListByTaskID(taskID);
        }

        public StepDTO SelectByID(int t)
        {
            return stepDAO.SelectByID(t);
        }
    }
}
