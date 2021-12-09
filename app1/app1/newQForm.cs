using app1.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace app1
{
    public partial class newQForm : Form
    {
        BusinessLogic bl;
        private string username;
        qFormHelper h;
        public newQForm(string username)
        {
            InitializeComponent();
            this.username = username;
            bl = new BusinessLogic(username);
            h = new qFormHelper(username);
            avgNum.Text = "   -";
            MinNum.Text = "   -";
            MaxNum.Text = "   -";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            noMeasuresText();
            listBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Today")
            {
                h.writeList(listBox1, h.qList(DateTime.Now.Date, DateTime.Now.Date));
            }
            else if (comboBox1.SelectedItem.ToString() == "Yesterday")
            {
                h.writeList(listBox1, h.qList(DateTime.Now.AddDays(-1).Date, DateTime.Now.AddDays(-1).Date));
            }
            else if (comboBox1.SelectedItem.ToString() == "Last 7 days")
            {
                h.writeList(listBox1, h.qList(DateTime.Now.AddDays(-7).Date, DateTime.Now.Date.AddDays(1)));
            }
            else if (comboBox1.SelectedItem.ToString() == "Last 30 days")
            {
                h.writeList(listBox1, h.qList(DateTime.Now.AddDays(-31).Date, DateTime.Now.Date.AddDays(1)));
            }
            else if (comboBox1.SelectedItem.ToString() == "Every measure")
            {
                var list = bl.everyMeasure().OrderBy(x => x.When).ToList();

                foreach (Measure item in list)
                {
                    listBox1.Items.Add(item);
                }
            }

            if (radioButton1.Checked)
            {
                MeinRadio(1);
            }
            else
            {
                MeinRadio(0.0555);
            }
               
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            new UserForm(username).Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            noMeasuresText();
            h.writeList(listBox1, h.qList(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date));

            if (radioButton1.Checked)
            {
                MeinRadio(1);
            }
            else
            {
                MeinRadio(0.0555);
            }    
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            noMeasuresText();
            MeinRadio(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            noMeasuresText();
            MeinRadio(0.0555);
        }

        public void MeinRadio(double x)
        {
            if (listBox1.Items.Count != 0)
            {
                avgNum.Text = (Math.Round( h.avg(listBox1) * x, 2 ) .ToString());
                MinNum.Text = (Math.Round( h.min(listBox1) * x, 2 ) .ToString());
                MaxNum.Text = (Math.Round( h.max(listBox1) * x, 2 ) .ToString());
            }
        }

        public void noMeasuresText()
        {
            avgNum.Text = "No measures";
            MinNum.Text = "No measures";
            MaxNum.Text = "No measures";
        }
    }
}
