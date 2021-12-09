using app1.Model;
using System;
using System.Windows.Forms;

namespace app1
{
    public partial class editMeasure : Form
    {
        BusinessLogic bl;
        private string username;
        private int id;
        public editMeasure(string username)
        {
            InitializeComponent();
            this.username = username;
            bl = new BusinessLogic(username);
            list();
            SaveBtn.Hide();
        }

        public void list()
        {
            listBox1.Items.Clear();
            foreach (Measure item in bl.everyMeasure())
            {
                listBox1.Items.Add(item);
            }
        }

        private void newM_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            string daytime = comboBox1daytime.SelectedItem.ToString();
            double rate = (double)numericUpDown1.Value;
            string unit = comboBox2Unit.SelectedItem.ToString();
            string critical = bl.unitConverter((double)rate, unit);
            bl.editMeasure(id, d, daytime, rate, unit, critical);
            list();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string s = listBox1.SelectedItem.ToString();
            string[] sTrim = s.Split(" ");
            this.id = Int32.Parse(sTrim[0]);
            dateTimePicker1.Value = DateTime.Parse(sTrim[1]);
            comboBox1daytime.SelectedItem = sTrim[2] + " " + sTrim[3];
            numericUpDown1.Value = Int32.Parse(sTrim[4]);
            comboBox2Unit.SelectedItem = sTrim[5];
            newM.Show();*/

            Measure m = new Measure();
            m = (Measure)listBox1.SelectedItem;
            this.id = m.Id;
            dateTimePicker1.Value = m.When;
            comboBox1daytime.SelectedItem = m.Daytime;
            numericUpDown1.Value = (decimal)m.Rate;
            comboBox2Unit.SelectedItem = m.Unit;
            SaveBtn.Show();
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            UserForm f = new UserForm(username);
            f.Show();
            this.Close();
        }

        private void editMeasure_Load(object sender, EventArgs e)
        {

        }
    }
}
