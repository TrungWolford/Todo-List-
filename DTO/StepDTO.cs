using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StepDTO
    {
        public int StepID { get; set; }
        public string StepName { get; set; }
        public bool IsDone { get; set; }
        public int TaskID { get; set; }

        public StepDTO() { }

        public StepDTO(int stepID, string stepName, bool isDone, int taskID)
        {
            StepID = stepID;
            StepName = stepName;
            IsDone = isDone;
            TaskID = taskID;
        }

        public override string ToString()
        {
            return $"StepDTO [StepID={StepID}, StepName={StepName}, IsDone={IsDone}, TaskID={TaskID}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (StepDTO)obj;
            return StepID == other.StepID &&
                   StepName == other.StepName &&
                   IsDone == other.IsDone &&
                   TaskID == other.TaskID;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + StepID.GetHashCode();
            hash = hash * 31 + StepName.GetHashCode();
            hash = hash * 31 + IsDone.GetHashCode();
            hash = hash * 31 + TaskID.GetHashCode();
            return hash;
        }
    }
}
