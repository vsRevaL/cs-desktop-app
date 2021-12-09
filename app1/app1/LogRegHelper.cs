using app1.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace app1
{
    class LogRegHelper
    {
        public bool checkLog(string username, string password, string password2)
        {
            PatientDB db = new PatientDB();
            foreach (Patient p in db.Patients)
            {
                if (p.Username == username &&
                    p.Password == password &&
                    p.Password == password2)
                {
                    return true;
                }
            }

            return false;
        }

        public void tryReg(string username, string FirstName, string Lastname, string p1, string p2, string adress, string phone, DateTime dof)
        {
            Regex input = new Regex("^[a-zA-Z]*$");
            if (!input.IsMatch(username))
            {
                MessageBox.Show("Only numbers are accepted", "Registration Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ultimateCheck(username,11)) return;
            else if (contains(username))
            {
                MessageBox.Show("There is already an user name " + username, "Registration Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ultimateCheck(FirstName,20) || !ultimateCheck(Lastname,20) || !input.IsMatch(FirstName) || !input.IsMatch(Lastname))
            {
                MessageBox.Show("Wrong First name, Last name input, only numbers", "Registration Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = new Regex("^[a-zA-Z0-9]*$");
            if (!ultimateCheck(p1,11) || !ultimateCheck(p2,11) || p1 != p2 || !input.IsMatch(p1) || !input.IsMatch(p2))
            {
                MessageBox.Show("Wrong password inputs. Only letters and/or numbers", "Registration Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = new Regex("^[0-9]*$");
            if (!ultimateCheck(adress, 10) || !input.IsMatch(adress))
            {
                MessageBox.Show("Wrong adress input. Only numbers [Postal code]", "Registration Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = new Regex("^[0-9]*$");
            if (!ultimateCheck(phone, 12) || !input.IsMatch(phone))
            {
                MessageBox.Show("Wrong phone input. Only numbers [0-9]", "Registration Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PatientDB db = new PatientDB();
            Patient p = new Patient();
            p.Username = username;
            p.FirstName = FirstName;
            p.Lastname = Lastname;
            p.Password = p1;
            p.Adress = adress;
            p.Phone = phone;
            p.DateOfBirth = dof;
            db.Add(p);
            db.SaveChanges();

            MessageBox.Show("Succesfull registration!");
        }

        private bool contains(string username)
        {
            PatientDB db = new PatientDB();
            foreach (Patient item in db.Patients)
            {
                if (item.Username == username)
                {
                    return true;
                }
            }

            return false;
        }

        public bool ultimateCheck(string inp, int m)
        {
 
            if(String.IsNullOrEmpty(inp))
            {
                MessageBox.Show("Empty field", " Error ",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (inp.Contains(" "))
            {
                MessageBox.Show("Spaces in the input", " Error ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (inp.Length >= m)
            {

                MessageBox.Show("Input needs to be shorter than " + m, " Error ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
