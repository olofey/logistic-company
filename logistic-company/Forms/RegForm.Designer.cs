namespace logistic_company.Forms
{
    partial class RegForm
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
            this.pnlNameCompany = new System.Windows.Forms.Panel();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlNameCompany.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNameCompany
            // 
            this.pnlNameCompany.Controls.Add(this.lblNameCompany);
            this.pnlNameCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNameCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlNameCompany.Name = "pnlNameCompany";
            this.pnlNameCompany.Size = new System.Drawing.Size(369, 40);
            this.pnlNameCompany.TabIndex = 1;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameCompany.Location = new System.Drawing.Point(29, 9);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(304, 18);
            this.lblNameCompany.TabIndex = 0;
            this.lblNameCompany.Text = "Логистическая компания Trucks Cargo";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tbxEmail);
            this.pnlContent.Controls.Add(this.lblEmail);
            this.pnlContent.Controls.Add(this.btnReg);
            this.pnlContent.Controls.Add(this.tbxPassword);
            this.pnlContent.Controls.Add(this.tbxLogin);
            this.pnlContent.Controls.Add(this.lblPassword);
            this.pnlContent.Controls.Add(this.lblLogin);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(369, 211);
            this.pnlContent.TabIndex = 2;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(110, 134);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(175, 23);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(110, 82);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(175, 20);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.Text = "p6ketyup";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(110, 56);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(175, 20);
            this.tbxLogin.TabIndex = 3;
            this.tbxLogin.Text = "alexsonz";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.lblPassword.Location = new System.Drawing.Point(50, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Пароль:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.lblLogin.Location = new System.Drawing.Point(50, 58);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 16);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(110, 108);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(175, 20);
            this.tbxEmail.TabIndex = 7;
            this.tbxEmail.Text = "alexanderalexander5@yandex.ru";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.lblEmail.Location = new System.Drawing.Point(57, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 251);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNameCompany);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.pnlNameCompany.ResumeLayout(false);
            this.pnlNameCompany.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNameCompany;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
    }
}