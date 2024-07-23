namespace fullRealProject
{
    partial class addEditUser
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

        #region Windows Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.person = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TabPage();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.passErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.cPassErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.addEditPerson1 = new fullRealProject.addEditPerson();
            this.filterWithPersonInfoUC1 = new fullRealProject.filterWithPersonInfoUC();
            this.tabControl1.SuspendLayout();
            this.person.SuspendLayout();
            this.user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPassErr)).BeginInit();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.formTitle.Location = new System.Drawing.Point(440, 37);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(310, 51);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.person);
            this.tabControl1.Controls.Add(this.user);
            this.tabControl1.Location = new System.Drawing.Point(42, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 555);
            this.tabControl1.TabIndex = 1;
            // 
            // person
            // 
            this.person.Controls.Add(this.filterWithPersonInfoUC1);
            this.person.Controls.Add(this.addEditPerson1);
            this.person.Controls.Add(this.button1);
            this.person.Location = new System.Drawing.Point(4, 25);
            this.person.Name = "person";
            this.person.Padding = new System.Windows.Forms.Padding(3);
            this.person.Size = new System.Drawing.Size(1139, 526);
            this.person.TabIndex = 0;
            this.person.Text = "Person Info";
            this.person.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1027, 256);
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
            this.user.Size = new System.Drawing.Size(1139, 431);
            this.user.TabIndex = 1;
            this.user.Text = "User Info";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
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
            this.cPassword.PasswordChar = '*';
            this.cPassword.Size = new System.Drawing.Size(116, 22);
            this.cPassword.TabIndex = 8;
            this.cPassword.TextChanged += new System.EventHandler(this.cPassword_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(160, 103);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
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
            // addEditPerson1
            // 
            this.addEditPerson1.Location = new System.Drawing.Point(29, 44);
            this.addEditPerson1.Name = "addEditPerson1";
            this.addEditPerson1.Size = new System.Drawing.Size(797, 415);
            this.addEditPerson1.TabIndex = 2;
            this.addEditPerson1.Load += new System.EventHandler(this.addEditPerson1_Load);
            // 
            // filterWithPersonInfoUC1
            // 
            this.filterWithPersonInfoUC1.BackColor = System.Drawing.SystemColors.Window;
            this.filterWithPersonInfoUC1.Location = new System.Drawing.Point(6, 6);
            this.filterWithPersonInfoUC1.Name = "filterWithPersonInfoUC1";
            this.filterWithPersonInfoUC1.Size = new System.Drawing.Size(996, 499);
            this.filterWithPersonInfoUC1.TabIndex = 4;
            // 
            // addEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 683);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.formTitle);
            this.Name = "addEditUser";
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

        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage person;
        private System.Windows.Forms.TabPage user;
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
        private addEditPerson addEditPerson1;
        private filterWithPersonInfoUC filterWithPersonInfoUC1;
    }
}