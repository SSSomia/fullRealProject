using businessLayer0;
using manageApplicationTypesBusiness;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace fullRealProject
{
    public partial class editAppType : Form
    {
   
        clsApplicationType _appType;
        private int _appTypeID = 0;
        public editAppType(int appTypeID)
        {
            _appTypeID = appTypeID;
            InitializeComponent();
        }
        private clsApplicationType _fillData()
        {
            _appType = new clsApplicationType(title.Text, int.Parse(fees.Text));
            return _appType;
        }

        private void _loadData()
        {
            _appType = clsApplicationType.printAppType(_appTypeID);
        }
        private void fees_TextChanged(object sender, EventArgs e)
        {
        }

        private void fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.enterNumricVal(sender, e);

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void title_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void editAppType_Load(object sender, EventArgs e)
        {
            _loadData();
            title.Text = _appType.title;
            fees.Text = _appType.fees.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (title.Text == "" || fees.Text == "")
            {
                MessageBox.Show("empty fields");
                return;
            }
            else
            {
                clsApplicationType.updateAppType(_fillData(), _appTypeID);
                this.Close();
            }

    

}
    }
}
