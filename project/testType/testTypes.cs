using businessLayer0;
using testTypesBusiness;
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
    public partial class testTypes : Form
    {
        public testTypes()
        {
            InitializeComponent();
        }
        private void _rowNums()
        {
            rowsNum.Text = clsTestType.numOfRows().ToString();
        }
        private void _loadtestTypes()
        {
            listTestTypes.DataSource = clsTestType.getAllTestTypes();
        }
        private void testTypes_Load(object sender, EventArgs e)
        {
            _loadtestTypes();
            _rowNums();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new editTestType((int)listTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _loadtestTypes();
        }
    }
}
