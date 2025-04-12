

using Google.Cloud.Firestore;
using User_Registration_Confirmation.Classes;
using User_Registration_Confirmation.EmailService;
using User_Registration_Confirmation.Forms;

namespace User_Registration_Confirmation
{
    public partial class Form1 : Form
    {
        private int OTp;

        public Form1()
        {
            InitializeComponent();
            
        }

        public int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }

        private async void btnGenerateOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Please enter your email address!");
                return;
            }

            OTp = GenerateOTP(); // Tạo OTP mới
            string toMail = tbEmail.Text;
            string subject = "Your OTP Code";
            string body = $"Your OTP code is: {OTp}\nThis code is valid for only one attempt.";

            try
            {
                await SendMailSMTP.SendMail(toMail, subject, body); // Gửi OTP qua email

                MessageBox.Show("OTP was sent successfully!");
                btnRegister.Enabled = true; // Bật nút Đăng ký
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var _db = FirestoreHelper.db;
            if (await CheckIfUserALreadyExists())
            {
                MessageBox.Show("Username already exists");
                return;
            }

            if (string.IsNullOrEmpty(tbOTP.Text))
            {
                MessageBox.Show("Please enter the OTP!");
                return;
            }
            if (OTp.ToString() != tbOTP.Text)
            {
                MessageBox.Show("Invalid OTP!");
                OTp = 0; // Reset OTP
                return;
            }
            var data = GetWriteData();
            DocumentReference docRef = _db.Collection("Username").Document(data.Username);
            await docRef.SetAsync(data);
            MessageBox.Show("Register Success");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private UserData GetWriteData()
        {
            string username = tbUserName.Text.Trim();
            string password = Security.Encrypt(tbPassword.Text);
            string gender = cbGender.Text;
            string email = tbEmail.Text.Trim();
            int zip = OTp;
            return new UserData()
            {
                Username = username,
                Password = password,
                Gender = gender,
                Zipcode = zip,
                Email = email
            };
        }

        private async Task<bool> CheckIfUserALreadyExists()
        {
            var _db = FirestoreHelper.db;
            if (_db == null)
            {
                throw new InvalidOperationException("Database connection is not initialized.");
            }
            string username = tbUserName.Text.Trim();
            DocumentReference docRef = _db.Collection("Username").Document(username);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            return snapshot.Exists;
        }
    }
}
