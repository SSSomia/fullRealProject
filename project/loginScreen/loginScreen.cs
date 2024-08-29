using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userBusiness;

namespace fullRealProject
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        // there is a problem that i can't close the before call dashboard
        private void login_Click(object sender, EventArgs e)
        {
            int userID = clsUser.loginUser(userName.Text, password.Text);
            if (userID != -1)
            {
                Current_user.userName = userName.Text;
                Current_user.password = password.Text;
                Current_user.userID = userID;
                this.Hide();
                Form frm = new dashBoard();
                frm.ShowDialog();
                this.Close();

            }
            else {
                MessageBox.Show("this user is not active. user name or password isn't correct");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\fullRealPro";
                string valueName = "userName";
                string valueDataName = userName.Text;
                string valuePass = "password";
                string valueDataPass = password.Text;

                try
                {
                    // Write the value to the Registry
                    Registry.SetValue(keyPath, valueName, valueDataName, RegistryValueKind.String);
                    Registry.SetValue(keyPath, valuePass, valueDataPass, RegistryValueKind.String);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\fullRealPro";
            string valueName = "userName";
            string valuePass = "password";

            try
            {
                // Read the value from the Registry
                string valueDataName = Registry.GetValue(keyPath, valueName, null) as string;
                string valueDataPass= Registry.GetValue(keyPath, valuePass, null) as string;


                if (valueDataName != null && valueDataPass != null)
                {
                    userName.Text = valueDataName;
                    password.Text = valueDataPass;
                    checkBox1 .Checked = true;
                }
                else
                {
                    userName.Text = "";
                    password.Text = "";
                    checkBox1 .Checked = false;
                
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
