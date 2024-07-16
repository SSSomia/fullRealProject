namespace fullRealProject
{
    partial class addNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.person = new System.Windows.Forms.TabPage();
            this.personInfoUC1 = new fullRealProject.personInfoUC();
            this.user = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.nationalNumber = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.addNewPerson = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.person.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(440, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.person);
            this.tabControl1.Controls.Add(this.user);
            this.tabControl1.Location = new System.Drawing.Point(34, 167);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 411);
            this.tabControl1.TabIndex = 1;
            // 
            // person
            // 
            this.person.Controls.Add(this.personInfoUC1);
            this.person.Location = new System.Drawing.Point(4, 25);
            this.person.Name = "person";
            this.person.Padding = new System.Windows.Forms.Padding(3);
            this.person.Size = new System.Drawing.Size(1139, 382);
            this.person.TabIndex = 0;
            this.person.Text = "Person Info";
            this.person.UseVisualStyleBackColor = true;
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personInfoUC1.Location = new System.Drawing.Point(0, 1);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(938, 378);
            this.personInfoUC1.TabIndex = 0;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(4, 25);
            this.user.Name = "user";
            this.user.Padding = new System.Windows.Forms.Padding(3);
            this.user.Size = new System.Drawing.Size(1139, 382);
            this.user.TabIndex = 1;
            this.user.Text = "User Info";
            this.user.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "filter with national number :";
            // 
            // nationalNumber
            // 
            this.nationalNumber.Location = new System.Drawing.Point(267, 124);
            this.nationalNumber.Name = "nationalNumber";
            this.nationalNumber.Size = new System.Drawing.Size(100, 22);
            this.nationalNumber.TabIndex = 3;
            this.nationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nationalNumber_KeyPress);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(408, 124);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // addNewPerson
            // 
            this.addNewPerson.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewPerson.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPerson.Location = new System.Drawing.Point(958, 105);
            this.addNewPerson.Name = "addNewPerson";
            this.addNewPerson.Size = new System.Drawing.Size(216, 60);
            this.addNewPerson.TabIndex = 5;
            this.addNewPerson.Text = "Add New Person";
            this.addNewPerson.UseVisualStyleBackColor = false;
            this.addNewPerson.Click += new System.EventHandler(this.addNewPerson_Click);
            // 
            // addNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 617);
            this.Controls.Add(this.addNewPerson);
            this.Controls.Add(this.search);
            this.Controls.Add(this.nationalNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "addNewUser";
            this.Text = "addNewUser";
            this.tabControl1.ResumeLayout(false);
            this.person.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage person;
        private System.Windows.Forms.TabPage user;
        private System.Windows.Forms.Label label2;
        private personInfoUC personInfoUC1;
        private System.Windows.Forms.TextBox nationalNumber;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button addNewPerson;
    }
}