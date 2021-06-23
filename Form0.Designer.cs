namespace HomeLoan
{
    partial class Form0
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
            this.btnMan = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMan
            // 
            this.btnMan.Location = new System.Drawing.Point(12, 82);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(75, 23);
            this.btnMan.TabIndex = 0;
            this.btnMan.Text = "Manager";
            this.btnMan.UseVisualStyleBackColor = true;
            this.btnMan.Click += new System.EventHandler(this.btnMan_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(160, 82);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(75, 23);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "Employee";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 158);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnMan);
            this.Name = "Form0";
            this.Text = "Form0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Button btnEmp;
    }
}