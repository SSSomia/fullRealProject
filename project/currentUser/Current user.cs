using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userBusiness;

namespace fullRealProject
{
    internal class Current_user
    {
        public static string userName;
        public static string password;
        public static int userID;
        public static int personID = clsUser.getPersonID(userID);
    }
}
