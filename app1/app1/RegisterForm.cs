using System;
using System.Windows.Forms;

namespace app1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            LogRegHelper lrg = new LogRegHelper();
            string username = textBox1.Text;
            string FirstName = textBox2.Text;
            string Lastname = textBox3.Text;
            string p1 = textBox4.Text;
            string p2 = textBox5.Text;
            string adress= textBox6.Text;
            string phone = textBox7.Text;
            DateTime dof = dateTimePicker1.Value;
            lrg.tryReg(username, FirstName, Lastname, p1, p2, adress, phone, dof);
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
