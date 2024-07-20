using businessLayer0;
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
    public partial class add_editPerson : Form
    {
        public delegate void dataBackDlg(int personId);
        public event dataBackDlg endWithAddPerson;
        public add_editPerson(int personID)
        {
            InitializeComponent();
            if (personID == -1) 
            { 
                formTitle.Text = "ADD NEW PERSON";
                addEditPerson1.addPerson();
                addEditPerson1.endWithForm += endWithThisForm;
            }
            else
            {
                formTitle.Text = "MODIFIY PERSON";
                addEditPerson1.editPerson(personID);
                addEditPerson1.endWithForm += endWithThisForm;
            }
        }
        private void endWithThisForm(int nationalNum)
        {
            endWithAddPerson(nationalNum);
            this.Close();
        }

        private void add_editPerson_Load(object sender, EventArgs e)
        {
            
        }
    }
}
