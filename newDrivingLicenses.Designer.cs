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
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TabPage();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.filterWithPersonInfoUC1 = new fullRealProject.filterWithPersonInfoUC();
            this.tabControl1.SuspendLayout();
            this.person.SuspendLayout();
            this.user.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.user);
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
            // user
            // 
            this.user.Controls.Add(this.close);
            this.user.Controls.Add(this.save);
            this.user.Location = new System.Drawing.Point(4, 25);
            this.user.Name = "user";
            this.user.Padding = new System.Windows.Forms.Padding(3);
            this.user.Size = new System.Drawing.Size(1139, 488);
            this.user.TabIndex = 1;
            this.user.Text = "User Info";
            this.user.UseVisualStyleBackColor = true;
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
            // newDrivingLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 717);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "newDrivingLicenses";
            this.Text = "newDrivingLicenses";
            this.tabControl1.ResumeLayout(false);
            this.person.ResumeLayout(false);
            this.user.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage person;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage user;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private filterWithPersonInfoUC filterWithPersonInfoUC1;
    }
}