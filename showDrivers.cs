using driverBusiness;
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
    public partial class showDrivers : Form
    {
        public showDrivers()
        {
            InitializeComponent();
        }
        private void _loaddrivers()
        {
            drivers.DataSource = clsDriver.getAllDrivers();
        }

        private void showDrivers_Load(object sender, EventArgs e)
        {
            _loaddrivers();

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
