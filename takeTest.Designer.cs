namespace fullRealProject
{
    partial class takeTest
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
            this.pass = new System.Windows.Forms.RadioButton();
            this.fail = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(23, 37);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(59, 20);
            this.pass.TabIndex = 0;
            this.pass.TabStop = true;
            this.pass.Text = "Pass";
            this.pass.UseVisualStyleBackColor = true;
            // 
            // fail
            // 
            this.fail.AutoSize = true;
            this.fail.Location = new System.Drawing.Point(114, 37);
            this.fail.Name = "fail";
            this.fail.Size = new System.Drawing.Size(50, 20);
            this.fail.TabIndex = 1;
            this.fail.TabStop = true;
            this.fail.Text = "Fail";
            this.fail.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.fail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(126, 128);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(126, 169);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // takeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 210);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Name = "takeTest";
            this.Text = "takeTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton pass;
        private System.Windows.Forms.RadioButton fail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
    }
}