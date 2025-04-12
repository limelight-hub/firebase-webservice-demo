namespace User_Registration_Confirmation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerateOTP = new Button();
            cbGender = new ComboBox();
            grBoxRegister = new GroupBox();
            tbPassword = new TextBox();
            lbpassWord = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            tbOTP = new TextBox();
            lbOTP = new Label();
            lbGender = new Label();
            tbEmail = new TextBox();
            lbEmail = new Label();
            tbUserName = new TextBox();
            lbName = new Label();
            picImage = new PictureBox();
            grBoxRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateOTP
            // 
            btnGenerateOTP.BackColor = Color.FromArgb(255, 192, 128);
            btnGenerateOTP.FlatStyle = FlatStyle.Popup;
            btnGenerateOTP.Location = new Point(224, 124);
            btnGenerateOTP.Name = "btnGenerateOTP";
            btnGenerateOTP.Size = new Size(168, 29);
            btnGenerateOTP.TabIndex = 0;
            btnGenerateOTP.Text = "Generate OTP";
            btnGenerateOTP.UseVisualStyleBackColor = false;
            btnGenerateOTP.Click += btnGenerateOTP_Click;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Orthers" });
            cbGender.Location = new Point(97, 124);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 29);
            cbGender.TabIndex = 1;
            // 
            // grBoxRegister
            // 
            grBoxRegister.Controls.Add(tbPassword);
            grBoxRegister.Controls.Add(lbpassWord);
            grBoxRegister.Controls.Add(btnLogin);
            grBoxRegister.Controls.Add(btnRegister);
            grBoxRegister.Controls.Add(tbOTP);
            grBoxRegister.Controls.Add(lbOTP);
            grBoxRegister.Controls.Add(lbGender);
            grBoxRegister.Controls.Add(tbEmail);
            grBoxRegister.Controls.Add(lbEmail);
            grBoxRegister.Controls.Add(tbUserName);
            grBoxRegister.Controls.Add(cbGender);
            grBoxRegister.Controls.Add(lbName);
            grBoxRegister.Controls.Add(btnGenerateOTP);
            grBoxRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grBoxRegister.Location = new Point(12, 189);
            grBoxRegister.Name = "grBoxRegister";
            grBoxRegister.Size = new Size(409, 325);
            grBoxRegister.TabIndex = 2;
            grBoxRegister.TabStop = false;
            grBoxRegister.Text = "Registration";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(97, 203);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(295, 29);
            tbPassword.TabIndex = 11;
            // 
            // lbpassWord
            // 
            lbpassWord.AutoSize = true;
            lbpassWord.Font = new Font("Segoe UI", 12F);
            lbpassWord.Location = new Point(6, 206);
            lbpassWord.Name = "lbpassWord";
            lbpassWord.Size = new Size(76, 21);
            lbpassWord.TabIndex = 10;
            lbpassWord.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SpringGreen;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(6, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(392, 29);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "I already have account";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SpringGreen;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Location = new Point(6, 251);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(392, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbOTP
            // 
            tbOTP.Location = new Point(97, 168);
            tbOTP.Name = "tbOTP";
            tbOTP.Size = new Size(295, 29);
            tbOTP.TabIndex = 7;
            // 
            // lbOTP
            // 
            lbOTP.AutoSize = true;
            lbOTP.Font = new Font("Segoe UI", 12F);
            lbOTP.Location = new Point(6, 171);
            lbOTP.Name = "lbOTP";
            lbOTP.Size = new Size(38, 21);
            lbOTP.TabIndex = 6;
            lbOTP.Text = "OTP";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 12F);
            lbGender.Location = new Point(6, 132);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(61, 21);
            lbGender.TabIndex = 5;
            lbGender.Text = "Gender";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(97, 80);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(295, 29);
            tbEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F);
            lbEmail.Location = new Point(6, 83);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(48, 21);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(97, 36);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(295, 29);
            tbUserName.TabIndex = 2;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 12F);
            lbName.Location = new Point(6, 39);
            lbName.Name = "lbName";
            lbName.Size = new Size(88, 21);
            lbName.TabIndex = 0;
            lbName.Text = "User Name";
            // 
            // picImage
            // 
            picImage.Image = Properties.Resources._7;
            picImage.Location = new Point(12, 12);
            picImage.Name = "picImage";
            picImage.Size = new Size(409, 171);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 3;
            picImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 536);
            Controls.Add(picImage);
            Controls.Add(grBoxRegister);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            grBoxRegister.ResumeLayout(false);
            grBoxRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerateOTP;
        private ComboBox cbGender;
        private GroupBox grBoxRegister;
        private Label lbName;
        private TextBox tbUserName;
        private TextBox tbEmail;
        private Label lbEmail;
        private Label lbGender;
        private Button btnRegister;
        private TextBox tbOTP;
        private Label lbOTP;
        private PictureBox picImage;
        private Button btnLogin;
        private TextBox tbPassword;
        private Label lbpassWord;
    }
}
