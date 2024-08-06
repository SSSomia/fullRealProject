using personTestsBusiness;
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
    public partial class takeTest : Form
    {
        private int _id;
        private int _applicationID;
        public takeTest(int id, int applicationID)
        {
            InitializeComponent();
            _id = id;
            _applicationID = applicationID;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool passed = false;
            if (pass.Checked) 
            {
                passed = true;  
            }
            int numOfPass = clsPersonTest.takeTest(_id, passed, _applicationID);
            if (numOfPass == 3) { clsPersonTest.updateState(_applicationID, "completed"); }
            this.Close();
        }
    }
}
