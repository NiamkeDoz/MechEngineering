namespace MotorList
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FNameTxtBx = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.CreateLbl);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 58);
            this.panel1.TabIndex = 0;
            // 
            // CreateLbl
            // 
            this.CreateLbl.AutoSize = true;
            this.CreateLbl.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(183)))), ((int)(((byte)(184)))));
            this.CreateLbl.Location = new System.Drawing.Point(111, 10);
            this.CreateLbl.Name = "CreateLbl";
            this.CreateLbl.Size = new System.Drawing.Size(215, 33);
            this.CreateLbl.TabIndex = 1;
            this.CreateLbl.Text = "Create An Account";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 601);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(92, 37);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FNameTxtBx
            // 
            this.FNameTxtBx.Location = new System.Drawing.Point(116, 161);
            this.FNameTxtBx.Name = "FNameTxtBx";
            this.FNameTxtBx.Size = new System.Drawing.Size(209, 20);
            this.FNameTxtBx.TabIndex = 2;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(450, 650);
            this.Controls.Add(this.FNameTxtBx);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CreateLbl;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox FNameTxtBx;
    }
}