using System;
using System.Windows.Forms;

namespace app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LogRegHelper lrg = new LogRegHelper();
            
            string username = usernameInp.Text;
            string password = passwordInp.Text;
            string password2 = confpasswordInp.Text;

            bool l = lrg.checkLog(username, password, password2);

            if(l)
            {
                UserForm uf = new UserForm(username);
                uf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed", " Error ",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
        }

        private void label6_Click(object sender, EventArgs e)
        {
            RegisterForm r = new RegisterForm();
            r.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordInp.UseSystemPasswordChar = true;
                confpasswordInp.UseSystemPasswordChar = true;
            }
            else
            {
                passwordInp.UseSystemPasswordChar = false;
                confpasswordInp.UseSystemPasswordChar = false;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            passwordInp.Text = "";
            usernameInp.Text = "";
            confpasswordInp.Text = "";
        }
    }
}
