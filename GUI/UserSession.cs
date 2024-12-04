using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class UserSession
    {
        public static string UserName { get; set; }

        public static void clear()
        {
            UserName = null;
        }
    }
}
