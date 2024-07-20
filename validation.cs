using businessLayer0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    internal class clsValidation
    {
        // empty text box
        public static bool emptyField(string text)
        {
            if (text.Length == 0)
            {
                return true;
            }
            return false;
        }

        public static void enterNumricVal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        public static bool passEquals(string pass, string cPass)
        {
            if (pass == cPass)
            {
                return true;
            }
            return false;
        }

        public static bool isNationalNumExist(int nationalNum)
        {
            if (clsPerson.isNationalNumExist(nationalNum))
            {
                return true ;
            }
            return false ;
        }


        public static bool phoneNum(string phone)
        {
            if (phone.Length > 11 || phone.Length < 11)
            {
                return false;
            }
            if (phone[0] != '0' && phone[1] != '1' & (phone[2] != '1' || phone[2] != '2' || phone[2] != '5' || phone[2] != '0'))
            { 
                return false;
            }
            if (phone.Length == 11 && (phone[0] == '0' && phone[1] == '1' & (phone[2] == '1' || phone[2] == '2' || phone[2] == '5' || phone[2] == '0')))
            { 
                return true;
            }
            return false;
        }

        public static bool email(string email)
        {
            if (email.Length == 0)
                return true;
            if (email.Length < 11)
                return false;
            if (email.Substring(email.Length - 10) != "@gmail.com")
            {
                return false;
            }
            return true;
        }

        public static bool isUserNameExist(string userName)
        {
            if (clsPerson.isUserNameExist(userName))
            {
                return true;
            }
            return false;
        }

        public static bool passwordLessThan4( string pass)
        {
            if (pass.Length < 4)
            {
                return true;
            }
            return false;
        }
    }
}
