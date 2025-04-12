using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Registration_Confirmation.Classes;
using Google.Cloud.Firestore;

namespace User_Registration_Confirmation.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnBackToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            form1.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            var _db = FirestoreHelper.db;
            DocumentReference docRef = _db.Collection("Username").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();
            if (data != null)
            {
                if (Security.Decrypt(data.Password) == password)
                {
                    MessageBox.Show("Login Success");
                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Username is not exists");
            }
        }
    }
}
