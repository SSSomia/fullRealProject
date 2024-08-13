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
    public partial class showUserDataFm : Form
    {
        public showUserDataFm(int userID, int personID)
        {
            InitializeComponent();
            showUserDataUC01.showData(userID, personID);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
