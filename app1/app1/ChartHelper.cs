using app1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace app1
{
    class ChartHelper
    {
        private string username;
        PatientDB db = new PatientDB();
        BusinessLogic bl;
        public ChartHelper(string username)
        {
            this.username = username;
            bl = new BusinessLogic(username);
        }

        public int gitgud(string unit, double rate)
        {
            if (unit == "mmol/l")
            {
                return (int)(bl.mmol_to_mg(rate));
            }
            else
            {
                return (int)rate;
            }
        }

       public void fillList(int[] list, string nap)
       {
            foreach (Measure item in db.Measures)
            {
                if (item.When.ToString("yyyy-MM-dd") == nap && item.Username == username)
                {  
                    switch (item.Daytime)
                    {
                        case "before breakfast":
                            list[0] = gitgud(item.Unit, item.Rate);
                            break;
                        case "after breakfast":
                            list[1] = gitgud(item.Unit, item.Rate);
                            break;
                        case "before dinner":
                            list[2] = gitgud(item.Unit, item.Rate);
                            break;
                        case "after dinner":
                            list[3] = gitgud(item.Unit, item.Rate);
                            break;
                        case "before supper":
                            list[4] = gitgud(item.Unit, item.Rate);
                            break;
                        case "after supper":
                            list[5] = gitgud(item.Unit, item.Rate);
                            break;
                        case "at night":
                            list[6] = gitgud(item.Unit, item.Rate);
                            break;
                    }
                }
            }
        }
        
        public void fillComboBox(ComboBox c)
        {
            List<DateTime> list = new List<DateTime>();

            foreach (Measure x in db.Measures)
            {
                if(x.Username == username && !element(list, x.When.ToString("yyyy-MM-dd")))
                {
                    list.Add(x.When);
                }
            }

            var result = from x in list orderby x select x.ToString("yyyy-MM-dd");

            foreach (string item in result)
            {
                c.Items.Add(item);
            }
        }

        private bool element(List<DateTime> list, string date)
        {
            foreach (DateTime item in list)
            {
                if (item.ToString("yyyy-MM-dd") == date)
                {
                    return true;
                }
            }

            return false;
        }
        
        public void changePhoneAdress(string phone, string adress)
        {
            PatientDB db = new PatientDB();
            foreach (Patient p in db.Patients)
            {
                if(p.Username == username)
                {
                    p.Phone = phone;
                    p.Adress = adress;
                    break;
                }
            }

            db.SaveChanges();  
        }
    }
}
