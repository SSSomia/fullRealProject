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
    public partial class tests : Form
    {
        private int _applicationID;
        public tests(string title, int applicationID, string licenseClass, int passedTests)
        {
            InitializeComponent();
            label1.Text = title;
           _applicationID = applicationID;
            applicationInfoUC1.showData(applicationID, licenseClass, passedTests);
        }
    }
}
