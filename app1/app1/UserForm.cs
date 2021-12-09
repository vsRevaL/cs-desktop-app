using System;
using System.Windows.Forms;

namespace app1
{
    public partial class UserForm : Form
    {
        private string username { get; set; }
        public UserForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void newM_Click(object sender, EventArgs e)
        {
            addMeasureForm amf = new addMeasureForm(username);
            amf.Show();
            this.Close();
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            exportMeasureForm emf = new exportMeasureForm(username);
            emf.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delMeasureForm dmf = new delMeasureForm(username);
            dmf.Show();
            this.Close();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            editMeasure em = new editMeasure(username);
            em.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChartForm c = new ChartForm(username);
            c.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newQForm q = new newQForm(username);
            q.Show();
            this.Close();
        }
    }
}
