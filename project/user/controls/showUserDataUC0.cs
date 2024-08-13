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
    public partial class showUserDataUC0 : UserControl
    {
        public showUserDataUC0()
        {
            InitializeComponent();
           
        }

        public void showData(int userID, int personID)
        {
            personInfoUC1.showData(personID);
            userInfoUC1.showData(userID);

        }

        private void showUserDataUC_Load(object sender, EventArgs e)
        {

        }
    }
}
