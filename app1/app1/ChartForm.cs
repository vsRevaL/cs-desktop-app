using app1.Model;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace app1
{
    public partial class ChartForm : Form
    {
        
        private string username;
        Chart chart1;
        ChartHelper ch;
        LogRegHelper lrh;

        public ChartForm(string username)
        {
            InitializeComponent();
            this.username = username;
            ch = new ChartHelper(username);
            chart1 = new Chart();
            lrh = new LogRegHelper();

            ch.fillComboBox(comboBox1);
            profile();
            disabled();   
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm(username);
            uf.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nap = comboBox1.SelectedItem.ToString();
            int[] list = new int[7];

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = 0;
            }
            
            ch.fillList(list, nap);
            drawChart1(list);
        }

        private void drawChart1(int[] list)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Palette = ChartColorPalette.SemiTransparent;

            ChartArea ca = new ChartArea();
            ca.BackColor = Color.White;
   
            chart1.ChartAreas.Add(ca);

            Series ser = new Series();
            chart1.Series.Add(ser);
            ser.ChartType = SeriesChartType.Column;
            ser.ShadowColor = Color.Cyan;
            ser.ShadowOffset = 4;
 
            foreach (int item in list)
            {
                chart1.Series["Series1"].Points.AddXY(" ", item);
            }

            chart1.Top = 85;
            chart1.Left = -25;
            chart1.Width = 480;
            chart1.Height = 391;
            Controls.Add(chart1);
            profile();
        }

        private void profile()
        {
            PatientDB db = new PatientDB();
            foreach (Patient p in db.Patients)
            {
                if(p.Username == username)
                {
                    nameLabel.Text = p.FirstName + " " + p.Lastname;
                    adressLabel.Text = p.Adress;
                    phoneLabel.Text = p.Phone;
                    birthLabel.Text = p.DateOfBirth.ToString("yyyy-MM-dd");
                    break;
                }
            }
        }

        private void adressLabel_MouseClick(object sender, MouseEventArgs e)
        {
            enabled();
            textBox1.Text = adressLabel.Text;
            Adress.ForeColor = Color.Green;
            Phone.ForeColor = default;
        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {
            enabled();
            textBox1.Text = phoneLabel.Text;
            Adress.ForeColor = default;
            Phone.ForeColor = Color.Green;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            disabled();
            Phone.ForeColor = default;
            Adress.ForeColor = default;
            textBox1.Text = "";
        }

        private void birthLabel_Click(object sender, EventArgs e)
        {
            disabled();
            Phone.ForeColor = default;
            Adress.ForeColor = default;
            textBox1.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Regex input = new Regex("^[0-9]*$");
            if (Phone.ForeColor == Color.Green)
            {
                if(!lrh.ultimateCheck(textBox1.Text, 12) || !input.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Wrong phone input. Only numbers [0-9]", " Error ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ch.changePhoneAdress(textBox1.Text, adressLabel.Text);
                }
                
            }
            else if(Adress.ForeColor == Color.Green)
            {
                if (!lrh.ultimateCheck(textBox1.Text, 10) || !input.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Wrong adress input. Only numbers [Postal code]", " Error ",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ch.changePhoneAdress(phoneLabel.Text, textBox1.Text);
                }
            }

            profile();
        }

        private void enabled()
        {
            SaveBtn.Enabled = true;
            textBox1.Enabled = true;
        }
        private void disabled()
        {
            SaveBtn.Enabled = false;
            textBox1.Enabled = false;
        }
    }
}
