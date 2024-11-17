using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaskCommentDTO
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public int UserID { get; set; }
        public int TaskID { get; set; }
        public DateTime CreatedDate { get; set; }

        public TaskCommentDTO() { }

        public TaskCommentDTO(int commentID, string commentText, int userID, int taskID, DateTime createdDate)
        {
            CommentID = commentID;
            CommentText = commentText;
            UserID = userID;
            TaskID = taskID;
            CreatedDate = createdDate;
        }

        public override string ToString()
        {
            return $"TaskCommentDTO [CommentID={CommentID}, CommentText={CommentText}, UserID={UserID}, TaskID={TaskID}, CreatedDate={CreatedDate}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (TaskCommentDTO)obj;
            return CommentID == other.CommentID &&
                   CommentText == other.CommentText &&
                   UserID == other.UserID &&
                   TaskID == other.TaskID &&
                   CreatedDate == other.CreatedDate;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + CommentID.GetHashCode();
            hash = hash * 31 + (CommentText != null ? CommentText.GetHashCode() : 0);
            hash = hash * 31 + UserID.GetHashCode();
            hash = hash * 31 + TaskID.GetHashCode();
            hash = hash * 31 + CreatedDate.GetHashCode();
            return hash;
        }

    }
}
