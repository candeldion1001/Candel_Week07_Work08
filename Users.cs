using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candel_Week07_Work08
{
    public class Users
    {
        public String FullName { get; set; }
        public String Email { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public static List<Users> UserList = new List<Users>();
    }
}
