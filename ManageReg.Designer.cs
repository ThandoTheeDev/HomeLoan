namespace HomeLoan
{
    partial class ManageReg
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(62, 18);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 41;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(83, 219);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 20);
            this.txtT.TabIndex = 40;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(83, 187);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 20);
            this.txtS.TabIndex = 39;
            this.txtS.TextChanged += new System.EventHandler(this.txtS_TextChanged);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(83, 151);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 38;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(83, 116);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 36;
            this.txtP.UseSystemPasswordChar = true;
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(83, 84);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(100, 20);
            this.txtUN.TabIndex = 35;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(83, 53);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(100, 20);
            this.txtD.TabIndex = 34;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(86, 253);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 33;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(112, 291);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 32;
            this.btnRes.Text = "Reset";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(15, 291);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 31;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Date Of Bith:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Branch:";
            // 
            // ManageReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 345);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageReg";
            this.Text = "ManageReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}