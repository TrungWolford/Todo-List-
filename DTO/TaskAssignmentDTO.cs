using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaskAssignmentDTO
    {
        public int AssignmentID { get; set; }
        public int UserID { get; set; }
        public int TaskID { get; set; }
        public string AssignedBy { get; set; }
        public DateTime AssignedDate { get; set; }

        public TaskAssignmentDTO() { }

        public TaskAssignmentDTO(int assignmentID, int userID, int taskID, string assignedBy, DateTime assignedDate)
        {
            AssignmentID = assignmentID;
            UserID = userID;
            TaskID = taskID;
            AssignedBy = assignedBy;
            AssignedDate = assignedDate;    
        }

        public override string ToString()
        {
            return $"TaskAssignmentDTO [AssignmentID={AssignmentID}, UserID={UserID}, TaskID={TaskID}, AssignedBy={AssignedBy}, AssignedDate={AssignedDate}]";
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
                   AssignedBy == other.AssignedBy &&
                   AssignedDate == other.AssignedDate;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + AssignmentID.GetHashCode();
            hash = hash * 31 + UserID.GetHashCode();
            hash = hash * 31 + TaskID.GetHashCode();
            hash = hash * 31 + (AssignedBy != null ? AssignedBy.GetHashCode() : 0);
            hash = hash * 31 + AssignedDate.GetHashCode();
            return hash;
        }
    }
}
