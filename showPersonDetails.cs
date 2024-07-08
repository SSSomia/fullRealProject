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
    public partial class showPersonDetails : Form
    {
        private int _ind, _mode;
        public showPersonDetails(int index, int mode)
        {
            _ind = index; _mode = mode;
            InitializeComponent();
        }

        private void showPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void personInfoUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
