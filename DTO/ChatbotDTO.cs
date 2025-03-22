using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class ChatbotDTO
    {
        public int IDbot {  get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public ChatbotDTO() { }
        public ChatbotDTO(int id, string question, string answer)
        {
            this.IDbot = id;
            this.Question = question;
            this.Answer = answer;
        }

        public override string ToString()
        {
            return $"ChatbotDTO [IDbot={IDbot}, Question={Question}, Answer={Answer}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (ChatbotDTO)obj;
            return IDbot == other.IDbot &&
                   Question == other.Question &&
                   Answer == other.Answer;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + IDbot.GetHashCode();
            hash = hash * 31 + (Question != null ? Question.GetHashCode() : 0);
            hash = hash * 31 + (Answer != null ? Answer.GetHashCode() : 0);
            return hash;
        }
    }
}
