using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChatbotBUS
    {
        public List<ChatbotDTO> list;
        private static readonly ChatbotDAO chatbotDAO = ChatbotDAO.Instance;

        public ChatbotBUS()
        {
            list = chatbotDAO.GetAll();
        }
    }
}

   
