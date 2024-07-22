namespace fullRealProject
{
    partial class changeUserPassword
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
            this.showUserDataUC01 = new fullRealProject.showUserDataUC0();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.cPass = new System.Windows.Forms.TextBox();
            this.currPassErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.newPassErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.cPassErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currPassErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPassErr)).BeginInit();
            this.SuspendLayout();
            // 
            // showUserDataUC01
            // 
            this.showUserDataUC01.Location = new System.Drawing.Point(117, 70);
            this.showUserDataUC01.Name = "showUserDataUC01";
            this.showUserDataUC01.Size = new System.Drawing.Size(973, 500);
            this.showUserDataUC01.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "change password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "current password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "new password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "confirm password:";
            // 
            // currPass
            // 
            this.currPass.Location = new System.Drawing.Point(305, 606);
            this.currPass.Name = "currPass";
            this.currPass.PasswordChar = '*';
            this.currPass.Size = new System.Drawing.Size(143, 22);
            this.currPass.TabIndex = 5;
            this.currPass.TextChanged += new System.EventHandler(this.currPass_TextChanged);
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(725, 604);
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '*';
            this.newPass.Size = new System.Drawing.Size(143, 22);
            this.newPass.TabIndex = 6;
            this.newPass.Click += new System.EventHandler(this.newPass_Click);
            this.newPass.TextChanged += new System.EventHandler(this.newPass_TextChanged);
            // 
            // cPass
            // 
            this.cPass.Location = new System.Drawing.Point(725, 680);
            this.cPass.Name = "cPass";
            this.cPass.PasswordChar = '*';
            this.cPass.Size = new System.Drawing.Size(143, 22);
            this.cPass.TabIndex = 7;
            this.cPass.TextChanged += new System.EventHandler(this.cPass_TextChanged);
            // 
            // currPassErr
            // 
            this.currPassErr.ContainerControl = this;
            // 
            // newPassErr
            // 
            this.newPassErr.ContainerControl = this;
            // 
            // cPassErr
            // 
            this.cPassErr.ContainerControl = this;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(977, 736);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(113, 51);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // changeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 813);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.currPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showUserDataUC01);
            this.Name = "changeUserPassword";
            this.Text = "changeUserPassword";
            ((System.ComponentModel.ISupportInitialize)(this.currPassErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPassErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private showUserDataUC0 showUserDataUC01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox cPass;
        private System.Windows.Forms.ErrorProvider currPassErr;
        private System.Windows.Forms.ErrorProvider newPassErr;
        private System.Windows.Forms.ErrorProvider cPassErr;
        private System.Windows.Forms.Button save;
    }
}