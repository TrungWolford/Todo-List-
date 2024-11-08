using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class TaskLogDTO
    {
        public int TaskLogID { get; set; }
        public int TaskID { get; set; }
        public int Action {  get; set; }
        public DateTime ActionTime { get; set; }
        public string PerformedBy { get; set; }

        public TaskLogDTO() { }

        public TaskLogDTO(int taskLogID, int taskID, int action, DateTime actionTime, string performedBy)
        {
            TaskLogID = taskLogID;
            TaskID = taskID;
            Action = action;
            ActionTime = actionTime;
            PerformedBy = performedBy;
        }

        public override string ToString()
        {
            return $"TaskLogDTO [TaskLogID={TaskLogID}, TaskID={TaskID}, Action={Action}, ActionTime={ActionTime}, PerformedBy={PerformedBy}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (TaskLogDTO)obj;
            return TaskLogID == other.TaskLogID &&
                   TaskID == other.TaskID &&
                   Action == other.Action &&
                   ActionTime == other.ActionTime &&
                   PerformedBy == other.PerformedBy;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + TaskLogID.GetHashCode();
            hash = hash * 31 + TaskID.GetHashCode();
            hash = hash * 31 + Action.GetHashCode();
            hash = hash * 31 + ActionTime.GetHashCode();
            hash = hash * 31 + (PerformedBy != null ? PerformedBy.GetHashCode() : 0);
            return hash;
        }

    }
}
