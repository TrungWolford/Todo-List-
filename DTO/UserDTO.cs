namespace DTO
{
    internal class UserDTO
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }

        public UserDTO() { }
        public UserDTO(int userID, string userName, string password, string email, DateTime createdDate)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.Password = password;
            this.Email = email;
            this.CreatedDate = createdDate;
        }

        public override string ToString()
        {
            return $"UserDTO [UserID={UserID}, UserName={UserName}, Password={Password}, Email={Email}, CreatedDate={CreatedDate}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (UserDTO)obj;
            return UserID == other.UserID &&
                   UserName == other.UserName &&
                   Password == other.Password &&
                   Email == other.Email &&
                   CreatedDate == other.CreatedDate;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + UserID.GetHashCode();
            hash = hash * 31 + (UserName != null ? UserName.GetHashCode() : 0);
            hash = hash * 31 + (Password != null ? Password.GetHashCode() : 0);
            hash = hash * 31 + (Email != null ? Email.GetHashCode() : 0);
            hash = hash * 31 + (CreatedDate != null ? CreatedDate.GetHashCode() : 0);
            return hash;
        }
    }
}
