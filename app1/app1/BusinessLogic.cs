using app1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    class BusinessLogic
    {
        PatientDB db;

        private string username;

        public BusinessLogic(string username)
        {  
            this.username = username;
            db = new PatientDB();
        }

        public List<Measure> everyMeasure()
        {
            var result = from x in db.Measures where x.Username == username orderby x.When select x;
            return result.ToList();
        }

        public void deleteSelected(List<Measure> list)
        {
            var result = from item in list from m in db.Measures where m.Id == item.Id && m.Username == username select m;
            db.RemoveRange(result.ToList());
            db.SaveChanges();
        }

        public void delAll()
        {
            var result = from x in db.Measures where x.Username == username select x;
            db.RemoveRange(result.ToList());
            db.SaveChanges();
        }

        public void editMeasure(int id, DateTime d, string daytime, double rate, string unit, string critical)
        {
            foreach (Measure m in db.Measures)
            {
                if(id == m.Id && m.Username == username)
                {
                    m.When = d;
                    m.Daytime = daytime;
                    m.Rate = rate;
                    m.Unit = unit;
                    m.Critical = critical;
                    break;
                }
            }
            db.SaveChanges();
        }

        public string unitConverter(double rate, string unit)
        {
            string result = "";
            if (unit == "mmol/l")
            {
                if (rate < 4.0)
                {
                    result = "HYPO";
                }
                else if (rate > 13.0)
                {
                    result = "HIPER";
                }
                else
                {
                    result = "Normal";
                }
            }
            else if (unit == "mg/dl")
            {
                if (rate < 72.0)
                {
                    result = "HYPO";
                }
                else if (rate > 234.0)
                {
                    result = "HIPER";
                }
                else
                {
                    result = "Normal";
                }
            }

            return result;
        }

        public double mmol_to_mg(double m)
        {
            return m / 0.0555;
        }
    }
}
