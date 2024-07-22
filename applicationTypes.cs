using businessLayer0;
using manageApplicationTypesBusiness;
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
    public partial class applicationTypes : Form
    {
        public applicationTypes()
        {
            InitializeComponent();
        }
        private void _rowNums()
        {
            rowsNum.Text = clsApplicationType.numOfRows().ToString();
        }
        private void _loadApplicationTypes()
        {
            listAppTypes.DataSource = clsApplicationType.getAllApplicationTypes();
        }
        private void applicationTypes_Load(object sender, EventArgs e)
        {
            _loadApplicationTypes();
            _rowNums();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new editAppType((int)listAppTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _loadApplicationTypes();
        }
    }
}
