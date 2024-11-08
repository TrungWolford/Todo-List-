using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class GroupDTO
    {
        public int GroupID { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public GroupDTO() { }

        public GroupDTO(int groupID, string title, string createdBy, DateTime createdDate)
        {
            GroupID = groupID;
            Title = title;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
        }

        public override string ToString()
        {
            return $"GroupDTO [GroupID={GroupID}, Title={Title}, CreatedBy={CreatedBy}, CreatedDate={CreatedDate}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (GroupDTO)obj;
            return GroupID == other.GroupID &&
                   Title == other.Title &&
                   CreatedBy == other.CreatedBy &&
                   CreatedDate == other.CreatedDate;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + GroupID.GetHashCode();
            hash = hash * 31 + (Title != null ? Title.GetHashCode() : 0);
            hash = hash * 31 + (CreatedBy != null ? CreatedBy.GetHashCode() : 0);
            hash = hash * 31 + CreatedDate.GetHashCode();
            return hash;
        }

    }
}
