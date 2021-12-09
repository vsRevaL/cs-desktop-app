using app1.Model;
using System;
using System.Windows.Forms;

namespace app1
{
    public partial class addMeasureForm : Form
    {
        PatientDB db = new PatientDB();
        BusinessLogic bl;

        private string username { get; set; }
        public addMeasureForm(string username)
        {
            InitializeComponent();
            this.username = username;
            bl = new BusinessLogic(username);
            listMeasures();
        }

        private void listMeasures()
        {
            listBox1.Items.Clear();
            foreach (Measure item in bl.everyMeasure())
            {
                listBox1.Items.Add(item);
            }
        }

        private void newM_Click(object sender, EventArgs e)
        {
            if(comboBox1daytime.SelectedItem == null)
            {
                MessageBox.Show("No daytime attribute selected", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Measure item in db.Measures)
            {
                if (item.Username == username)
                {
                    if (item.Daytime == comboBox1daytime.SelectedItem.ToString() &&
                        item.When.ToString("yyyy-MM-dd") == dateTimePicker1.Value.ToString("yyyy-MM-dd"))
                    {
                        MessageBox.Show("There's already a [" + comboBox1daytime.SelectedItem.ToString() + "] measure on ["
                            + item.When.ToString("yyyy-MM-dd") + "]. Please use the [Edit Measure] option in the Menu." );
                        return;
                    }
                }
            }

            if(comboBox2Unit.SelectedItem == null)
            {
                MessageBox.Show("No unit attribute selected", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Measure m1 = new Measure();

            int maxid = 0;
            foreach (Measure m in db.Measures)
            {
                if (m.Id > maxid)
                {
                    maxid = m.Id;
                }
            }

            m1.Id = ++maxid;
            m1.Username = username;
            m1.When = dateTimePicker1.Value;
            m1.Daytime = comboBox1daytime.SelectedItem.ToString();
            m1.Rate = (double)numericUpDown1.Value;
            m1.Unit = comboBox2Unit.SelectedItem.ToString();
            m1.Critical = bl.unitConverter(m1.Rate, m1.Unit.ToString());

            db.Add(m1);
            db.SaveChanges();

            listMeasures();
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {  
            UserForm uf = new UserForm(username);
            uf.Show();
            this.Close();
        }
    }
}
