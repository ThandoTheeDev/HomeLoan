namespace HomeLoan
{
    partial class ManagerLogin
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
            this.btnMAL = new System.Windows.Forms.Button();
            this.btnMAR = new System.Windows.Forms.Button();
            this.btnARM = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMAL
            // 
            this.btnMAL.Location = new System.Drawing.Point(27, 130);
            this.btnMAL.Name = "btnMAL";
            this.btnMAL.Size = new System.Drawing.Size(75, 23);
            this.btnMAL.TabIndex = 0;
            this.btnMAL.Text = "Login";
            this.btnMAL.UseVisualStyleBackColor = true;
            this.btnMAL.Click += new System.EventHandler(this.btnMAL_Click);
            // 
            // btnMAR
            // 
            this.btnMAR.Location = new System.Drawing.Point(121, 130);
            this.btnMAR.Name = "btnMAR";
            this.btnMAR.Size = new System.Drawing.Size(75, 23);
            this.btnMAR.TabIndex = 1;
            this.btnMAR.Text = "Reset";
            this.btnMAR.UseVisualStyleBackColor = true;
            this.btnMAR.Click += new System.EventHandler(this.btnMAR_Click);
            // 
            // btnARM
            // 
            this.btnARM.Location = new System.Drawing.Point(218, 130);
            this.btnARM.Name = "btnARM";
            this.btnARM.Size = new System.Drawing.Size(75, 23);
            this.btnARM.TabIndex = 2;
            this.btnARM.Text = "Register";
            this.btnARM.UseVisualStyleBackColor = true;
            this.btnARM.Click += new System.EventHandler(this.btnARM_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(69, 28);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(69, 71);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 182);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnARM);
            this.Controls.Add(this.btnMAR);
            this.Controls.Add(this.btnMAL);
            this.Name = "ManagerLogin";
            this.Text = "ManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMAL;
        private System.Windows.Forms.Button btnMAR;
        private System.Windows.Forms.Button btnARM;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}