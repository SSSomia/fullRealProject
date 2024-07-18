using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using userBusiness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace fullRealProject
{
    public partial class userInfoUC : UserControl
    {
        private int _userID;
        clsUser _user;
        public userInfoUC()
        { 
            InitializeComponent();
        }
        public void showData(int userID)
        {
            _userID = userID;
            _loadUserData();
        }

        private void _loadUserData() 
        {
            _user = clsUser.printUser(_userID);
            _showUserInfo();
        }
        private void _showUserInfo()
        {
            if (_user!= null)
            {
                userName.Text = _user.userName.ToString();
                if (_user.isActive == true)
                {
                    isActive.Checked = true;
                }
                else
                    isActive.Checked = false;
            }
        }

        private void userInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
