namespace fullRealProject
{
    partial class newDrivingLicenses
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
            this.filterWithPersonInfoUC1 = new fullRealProject.filterWithPersonInfoUC();
            this.button1 = new System.Windows.Forms.Button();
            this.appInfo = new System.Windows.Forms.TabPage();
            this.licenseClass = new System.Windows.Forms.ComboBox();
            this.createBy = new System.Windows.Forms.Label();
            this.appFees = new System.Windows.Forms.Label();
            this.appDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.person.SuspendLayout();
            this.appInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(417, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Driving Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.person);
            this.tabControl1.Controls.Add(this.appInfo);
            this.tabControl1.Location = new System.Drawing.Point(28, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 517);
            this.tabControl1.TabIndex = 6;
            // 
            // person
            // 
            this.person.Controls.Add(this.filterWithPersonInfoUC1);
            this.person.Controls.Add(this.button1);
            this.person.Location = new System.Drawing.Point(4, 25);
            this.person.Name = "person";
            this.person.Padding = new System.Windows.Forms.Padding(3);
            this.person.Size = new System.Drawing.Size(1139, 488);
            this.person.TabIndex = 0;
            this.person.Text = "Person Info";
            this.person.UseVisualStyleBackColor = true;
            this.person.Click += new System.EventHandler(this.person_Click);
            // 
            // filterWithPersonInfoUC1
            // 
            this.filterWithPersonInfoUC1.BackColor = System.Drawing.SystemColors.Window;
            this.filterWithPersonInfoUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterWithPersonInfoUC1.Location = new System.Drawing.Point(6, 10);
            this.filterWithPersonInfoUC1.Name = "filterWithPersonInfoUC1";
            this.filterWithPersonInfoUC1.Size = new System.Drawing.Size(996, 472);
            this.filterWithPersonInfoUC1.TabIndex = 2;
            this.filterWithPersonInfoUC1.Load += new System.EventHandler(this.filterWithPersonInfoUC1_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1023, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // appInfo
            // 
            this.appInfo.Controls.Add(this.licenseClass);
            this.appInfo.Controls.Add(this.createBy);
            this.appInfo.Controls.Add(this.appFees);
            this.appInfo.Controls.Add(this.appDate);
            this.appInfo.Controls.Add(this.label5);
            this.appInfo.Controls.Add(this.label4);
            this.appInfo.Controls.Add(this.label3);
            this.appInfo.Controls.Add(this.label2);
            this.appInfo.Controls.Add(this.close);
            this.appInfo.Controls.Add(this.save);
            this.appInfo.Location = new System.Drawing.Point(4, 25);
            this.appInfo.Name = "appInfo";
            this.appInfo.Padding = new System.Windows.Forms.Padding(3);
            this.appInfo.Size = new System.Drawing.Size(1139, 488);
            this.appInfo.TabIndex = 1;
            this.appInfo.Text = "Application Info";
            this.appInfo.UseVisualStyleBackColor = true;
            this.appInfo.Click += new System.EventHandler(this.user_Click);
            // 
            // licenseClass
            // 
            this.licenseClass.DisplayMember = "1";
            this.licenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.licenseClass.Items.AddRange(new object[] {
            "class 1 - small motorcycle license",
            "class 2 - heavy motorcycle license",
            "class 3 - ordinary driving license",
            "class 4 - commercial",
            "class 5- agricultural",
            "class 6 - small and medium bus",
            "class 7 - truck and headvy vehicle"});
            this.licenseClass.Location = new System.Drawing.Point(281, 181);
            this.licenseClass.Name = "licenseClass";
            this.licenseClass.Size = new System.Drawing.Size(280, 24);
            this.licenseClass.TabIndex = 19;
            this.licenseClass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // createBy
            // 
            this.createBy.AutoSize = true;
            this.createBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBy.Location = new System.Drawing.Point(276, 346);
            this.createBy.Name = "createBy";
            this.createBy.Size = new System.Drawing.Size(27, 20);
            this.createBy.TabIndex = 18;
            this.createBy.Text = "---";
            // 
            // appFees
            // 
            this.appFees.AutoSize = true;
            this.appFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appFees.Location = new System.Drawing.Point(276, 268);
            this.appFees.Name = "appFees";
            this.appFees.Size = new System.Drawing.Size(27, 20);
            this.appFees.TabIndex = 17;
            this.appFees.Text = "---";
            // 
            // appDate
            // 
            this.appDate.AutoSize = true;
            this.appDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDate.Location = new System.Drawing.Point(276, 112);
            this.appDate.Name = "appDate";
            this.appDate.Size = new System.Drawing.Size(27, 20);
            this.appDate.TabIndex = 16;
            this.appDate.Text = "---";
            this.appDate.Click += new System.EventHandler(this.appDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Created By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Application Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "License Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Application Date:";
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
            // newDrivingLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 717);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "newDrivingLicenses";
            this.Text = "newDrivingLicenses";
            this.Load += new System.EventHandler(this.newDrivingLicenses_Load);
            this.tabControl1.ResumeLayout(false);
            this.person.ResumeLayout(false);
            this.appInfo.ResumeLayout(false);
            this.appInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage person;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage appInfo;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private filterWithPersonInfoUC filterWithPersonInfoUC1;
        private System.Windows.Forms.Label createBy;
        private System.Windows.Forms.Label appFees;
        private System.Windows.Forms.Label appDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox licenseClass;
    }
}