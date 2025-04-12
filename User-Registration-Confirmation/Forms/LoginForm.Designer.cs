namespace User_Registration_Confirmation.Forms
{
    partial class LoginForm
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
            lbUsername = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            btnBackToRegister = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(133, 91);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(87, 21);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "User name";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.Location = new Point(247, 83);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(230, 29);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(247, 133);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(230, 29);
            tbPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(133, 141);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(79, 21);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // btnBackToRegister
            // 
            btnBackToRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToRegister.Location = new Point(133, 207);
            btnBackToRegister.Name = "btnBackToRegister";
            btnBackToRegister.Size = new Size(162, 53);
            btnBackToRegister.TabIndex = 4;
            btnBackToRegister.Text = "Back To Register";
            btnBackToRegister.UseVisualStyleBackColor = true;
            btnBackToRegister.Click += btnBackToRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(315, 207);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 53);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 481);
            Controls.Add(btnLogin);
            Controls.Add(btnBackToRegister);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbPassword;
        private Button btnBackToRegister;
        private Button btnLogin;
    }
}