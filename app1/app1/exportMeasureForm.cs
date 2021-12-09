using app1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace app1
{
    public partial class exportMeasureForm : Form
    {
        private string username;
        BusinessLogic bl;
        public exportMeasureForm(string username)
        {
            InitializeComponent();
            this.username = username;
            bl = new BusinessLogic(username);
        }

        private void exportMeasureForm_Load(object sender, EventArgs e)
        {
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

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            UserForm f = new UserForm(username);
            f.Show();
            this.Close();   
        }

        private void exportSelectedBtn_Click(object sender, EventArgs e)
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
                exportToXML.InsertData(username, m);
                list();

                MessageBox.Show("Measures are succesfully exported");
            }
        }

        private void exportAllBtn_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("There is no measures to delete", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            PatientDB db = new PatientDB();
            exportToXML.InsertData(username, db.Measures.ToList());
            MessageBox.Show("All measures are exported ");
        }
    }
}
