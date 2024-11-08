using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class GroupMemberShipDTO
    {
        public int MemberShipID { get; set; }
        public int GroupID { get; set; }
        public int UserID { get; set; }
        public DateTime JoinedDate { get; set; }

        public GroupMemberShipDTO() { }

        public GroupMemberShipDTO(int memberShipID, int groupID, int userID, DateTime joinedDate)
        {
            MemberShipID = memberShipID;
            GroupID = groupID;
            UserID = userID;
            JoinedDate = joinedDate;
        }
        public override string ToString()
        {
            return $"GroupMemberShipDTO [MemberShipID={MemberShipID}, GroupID={GroupID}, UserID={UserID}, JoinedDate={JoinedDate}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (GroupMemberShipDTO)obj;
            return MemberShipID == other.MemberShipID &&
                   GroupID == other.GroupID &&
                   UserID == other.UserID &&
                   JoinedDate == other.JoinedDate;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + MemberShipID.GetHashCode();
            hash = hash * 31 + GroupID.GetHashCode();
            hash = hash * 31 + UserID.GetHashCode();
            hash = hash * 31 + JoinedDate.GetHashCode();
            return hash;
        }


    }
}
