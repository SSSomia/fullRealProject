namespace fullRealProject
{
    partial class add_editPerson
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
            this.formTitle = new System.Windows.Forms.Label();
            this.addEditPerson1 = new fullRealProject.addEditPerson();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.Location = new System.Drawing.Point(391, 38);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(0, 32);
            this.formTitle.TabIndex = 0;
            // 
            // addEditPerson1
            // 
            this.addEditPerson1.Location = new System.Drawing.Point(105, 134);
            this.addEditPerson1.Name = "addEditPerson1";
            this.addEditPerson1.Size = new System.Drawing.Size(887, 434);
            this.addEditPerson1.TabIndex = 1;
            // 
            // add_editPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 594);
            this.Controls.Add(this.addEditPerson1);
            this.Controls.Add(this.formTitle);
            this.Name = "add_editPerson";
            this.Text = "add_editPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formTitle;
        private addEditPerson addEditPerson1;
    }
}