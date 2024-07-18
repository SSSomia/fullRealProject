using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    public partial class showUserData : Form
    {
        public showUserData(int userID, int personID)
        {
            InitializeComponent();
            personInfoUC1.showData(personID);
            userInfoUC1.showData(userID);
        }

        private void showUserData_Load(object sender, EventArgs e)
        {

        }
    }
}
