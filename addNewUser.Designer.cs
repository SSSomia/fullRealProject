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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.person = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TabPage();
            this.save = new System.Windows.Forms.Button();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nationalNumber = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.addNewPerson = new System.Windows.Forms.Button();
            this.userNameErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.passErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.cPassErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.personInfoUC1 = new fullRealProject.personInfoUC();
            this.close = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.person.SuspendLayout();
            this.user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPassErr)).BeginInit();
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
            this.person.Controls.Add(this.button1);
            this.person.Controls.Add(this.personInfoUC1);
            this.person.Location = new System.Drawing.Point(4, 25);
            this.person.Name = "person";
            this.person.Padding = new System.Windows.Forms.Padding(3);
            this.person.Size = new System.Drawing.Size(1139, 382);
            this.person.TabIndex = 0;
            this.person.Text = "Person Info";
            this.person.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(987, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.Controls.Add(this.close);
            this.user.Controls.Add(this.save);
            this.user.Controls.Add(this.isActive);
            this.user.Controls.Add(this.label6);
            this.user.Controls.Add(this.cPassword);
            this.user.Controls.Add(this.password);
            this.user.Controls.Add(this.userName);
            this.user.Controls.Add(this.label5);
            this.user.Controls.Add(this.label4);
            this.user.Controls.Add(this.label3);
            this.user.Location = new System.Drawing.Point(4, 25);
            this.user.Name = "user";
            this.user.Padding = new System.Windows.Forms.Padding(3);
            this.user.Size = new System.Drawing.Size(1139, 382);
            this.user.TabIndex = 1;
            this.user.Text = "User Info";
            this.user.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightSteelBlue;
            this.save.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(970, 300);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(87, 44);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(145, 215);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(18, 17);
            this.isActive.TabIndex = 10;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Is Active:";
            // 
            // cPassword
            // 
            this.cPassword.Location = new System.Drawing.Point(229, 157);
            this.cPassword.Name = "cPassword";
            this.cPassword.Size = new System.Drawing.Size(116, 22);
            this.cPassword.TabIndex = 8;
            this.cPassword.TextChanged += new System.EventHandler(this.cPassword_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(160, 103);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(121, 22);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(160, 49);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(121, 22);
            this.userName.TabIndex = 6;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
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
            // userNameErr
            // 
            this.userNameErr.ContainerControl = this;
            // 
            // passErr
            // 
            this.passErr.ContainerControl = this;
            // 
            // cPassErr
            // 
            this.cPassErr.ContainerControl = this;
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personInfoUC1.Location = new System.Drawing.Point(0, 1);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(938, 378);
            this.personInfoUC1.TabIndex = 0;
            this.personInfoUC1.Load += new System.EventHandler(this.personInfoUC1_Load);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.LightSteelBlue;
            this.close.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(848, 300);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(87, 44);
            this.close.TabIndex = 11;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // addNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 602);
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
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPassErr)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider userNameErr;
        private System.Windows.Forms.ErrorProvider passErr;
        private System.Windows.Forms.ErrorProvider cPassErr;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
    }
}