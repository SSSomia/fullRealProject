﻿using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace fullRealProject
{
    public partial class managePerson : Form
    {
        public managePerson()
        {
            InitializeComponent();
        }


        private void _loadListPeople()
        {
            listPeople.DataSource = clsPerson.getAllPerson();
        }

        private void managePerson_Load(object sender, EventArgs e)
        {
            _loadListPeople();
            _rowNums();
        }

        private void _rowNums() 
        { 
            rowsNum.Text = clsPerson.numOfRows().ToString(); 
        }

        private void addNewPerson_Click(object sender, EventArgs e)
        {
            add_editPerson frm = new add_editPerson(-1);  // intialize object from form3   [1]
            frm.ShowDialog();
            _loadListPeople();
            _rowNums();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new personInfo((int)listPeople.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + listPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.deletePerson((int)listPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.");
                    _loadListPeople();
                    _rowNums();
                }

                else
                    MessageBox.Show("Person is not deleted.");

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_editPerson frm = new add_editPerson((int)listPeople.CurrentRow.Cells[0].Value);  // intialize object from form3   [1]
            frm.ShowDialog();
            
            _loadListPeople();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //didn't work
        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterBox.Text == "none")
            {
                filterBy.Visible = false;
            }
            else
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = listPeople.DataSource;
                if (filterBox.Text == "personID")
                    bs.Filter = listPeople.Columns[0].HeaderText.ToString() + " LIKE '%" + filterBy.Text + "%'";
                else if (filterBox.Text == "nationalNum")
                    bs.Filter = listPeople.Columns[2].HeaderText.ToString() + " LIKE '%" + filterBy.Text + "%'";
                else if (filterBox.Text == "firstName")
                    bs.Filter = listPeople.Columns[3].HeaderText.ToString() + " LIKE '%" + filterBy.Text + "%'";
                else if (filterBox.Text == "lastName")
                    bs.Filter = listPeople.Columns[4].HeaderText.ToString() + " LIKE '%" + filterBy.Text + "%'";
                else if (filterBox.Text == "phone")
                    bs.Filter = listPeople.Columns[5].HeaderText.ToString() + " LIKE '%" + filterBy.Text + "%'";
                else if (filterBox.Text == "email")
                    bs.Filter = listPeople.Columns[6].HeaderText.ToString() + " LIKE '%" + filterBy.Text + "%'";
                listPeople.DataSource = bs;
            }
        }
    }
}
