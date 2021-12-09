using app1.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace app1
{
    public partial class delMeasureForm : Form
    {
        BusinessLogic bl;
        private string username;

        public delMeasureForm(string username)
        {
            InitializeComponent();
            this.username = username;
            bl = new BusinessLogic(username);
            list();
        }

        private void delSelectedBtn_Click(object sender, EventArgs e)
        {
            List<Measure> m = new List<Measure>();

            foreach (object item in checkedListBox1.CheckedItems)
            {
                m.Add((Measure)item);
            }

            if (m.Count == 0)
            {
                MessageBox.Show("No measures were picked", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bl.deleteSelected(m);
                list();

                MessageBox.Show("Measures are succesfully deleted");
            }  
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            UserForm f = new UserForm(username);
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("There is no measures to delete", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bl.delAll();
            MessageBox.Show("All Measures are succesfully deleted");
            list();
        }

        public void list()
        {
            checkedListBox1.Items.Clear();
            foreach (Measure item in bl.everyMeasure())
            {
                checkedListBox1.Items.Add(item);
            }
        }
    }
}
