using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class TaskAssignmentDTO
    {
        public int AssignmentID { get; set; }
        public int UserID { get; set; }
        public int TaskID { get; set; }
        public string AssignedBy { get; set; }

        public TaskAssignmentDTO() { }

        public TaskAssignmentDTO(int assignmentID, int userID, int taskID, string assignedBy)
        {
            AssignmentID = assignmentID;
            UserID = userID;
            TaskID = taskID;
            AssignedBy = assignedBy;
        }

        public override string ToString()
        {
            return $"TaskAssignmentDTO [AssignmentID={AssignmentID}, UserID={UserID}, TaskID={TaskID}, AssignedBy={AssignedBy}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (TaskAssignmentDTO)obj;
            return AssignmentID == other.AssignmentID &&
                   UserID == other.UserID &&
                   TaskID == other.TaskID &&
                   AssignedBy == other.AssignedBy;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + AssignmentID.GetHashCode();
            hash = hash * 31 + UserID.GetHashCode();
            hash = hash * 31 + TaskID.GetHashCode();
            hash = hash * 31 + (AssignedBy != null ? AssignedBy.GetHashCode() : 0);
            return hash;
        }
    }
}
