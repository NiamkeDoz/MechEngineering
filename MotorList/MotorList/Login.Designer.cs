namespace MotorList
{
    partial class Login
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
            this.Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnameTxtBx = new System.Windows.Forms.TextBox();
            this.PwdTxtBx = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.UsernameErr = new System.Windows.Forms.Label();
            this.PasswordErr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(184)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 49);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(283, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 24);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // UnameTxtBx
            // 
            this.UnameTxtBx.BackColor = System.Drawing.Color.White;
            this.UnameTxtBx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameTxtBx.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UnameTxtBx.Location = new System.Drawing.Point(74, 124);
            this.UnameTxtBx.Name = "UnameTxtBx";
            this.UnameTxtBx.Size = new System.Drawing.Size(164, 23);
            this.UnameTxtBx.TabIndex = 1;
            this.UnameTxtBx.Text = "Username";
            this.UnameTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnameTxtBx.Enter += new System.EventHandler(this.Username_Enter);
            this.UnameTxtBx.Leave += new System.EventHandler(this.Uesrname_Leave);
            // 
            // PwdTxtBx
            // 
            this.PwdTxtBx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdTxtBx.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PwdTxtBx.Location = new System.Drawing.Point(74, 178);
            this.PwdTxtBx.Name = "PwdTxtBx";
            this.PwdTxtBx.Size = new System.Drawing.Size(164, 23);
            this.PwdTxtBx.TabIndex = 2;
            this.PwdTxtBx.Text = "Password";
            this.PwdTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PwdTxtBx.Enter += new System.EventHandler(this.Password_Enter);
            this.PwdTxtBx.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(74, 272);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(164, 36);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(128, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            // 
            // UsernameErr
            // 
            this.UsernameErr.AutoSize = true;
            this.UsernameErr.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameErr.ForeColor = System.Drawing.Color.Red;
            this.UsernameErr.Location = new System.Drawing.Point(99, 150);
            this.UsernameErr.Name = "UsernameErr";
            this.UsernameErr.Size = new System.Drawing.Size(116, 15);
            this.UsernameErr.TabIndex = 5;
            this.UsernameErr.Text = "*Incorrect Username";
            this.UsernameErr.Visible = false;
            // 
            // PasswordErr
            // 
            this.PasswordErr.AutoSize = true;
            this.PasswordErr.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordErr.ForeColor = System.Drawing.Color.Red;
            this.PasswordErr.Location = new System.Drawing.Point(102, 208);
            this.PasswordErr.Name = "PasswordErr";
            this.PasswordErr.Size = new System.Drawing.Size(113, 15);
            this.PasswordErr.TabIndex = 6;
            this.PasswordErr.Text = "*Incorrect Password";
            this.PasswordErr.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(320, 415);
            this.Controls.Add(this.PasswordErr);
            this.Controls.Add(this.UsernameErr);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PwdTxtBx);
            this.Controls.Add(this.UnameTxtBx);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnameTxtBx;
        private System.Windows.Forms.TextBox PwdTxtBx;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label UsernameErr;
        private System.Windows.Forms.Label PasswordErr;
    }
}

