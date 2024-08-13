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
using testTypesBusiness;

namespace fullRealProject
{
    public partial class editTestType : Form
    {
   
        clsTestType _testType;
        private int _testTypeID = 0;
        public editTestType(int appTypeID)
        {
            _testTypeID = appTypeID;
            InitializeComponent();
        }
        private clsTestType _fillData()
        {
            _testType = new clsTestType(title.Text,description.Text, int.Parse(fees.Text));
            return _testType;
        }

        private void _loadData()
        {
            _testType = clsTestType.printTestType(_testTypeID);
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

        private void editTestType_Load(object sender, EventArgs e)
        {
            _loadData();
            title.Text = _testType.title;
            description.Text = _testType.description;
            fees.Text = _testType.fees.ToString();
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
                clsTestType.udateTestType(_fillData(), _testTypeID);
                this.Close();
            }

    

}
    }
}
