using app1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace app1
{
    
    class qFormHelper
    {
        private string username;
        PatientDB db = new PatientDB();
        BusinessLogic bl;

        public qFormHelper(string username)
        {
            this.username = username;
            bl = new BusinessLogic(username);
        }

        public List<Measure> qList(DateTime d1, DateTime d2)
        {
            List<Measure> result = new List<Measure>();
            foreach (Measure item in db.Measures)
            {
                if(item.Username == username)
                {
                   if (DateTime.Compare(d1,d2) < 0 && (item.When.Date >= d1 && item.When.Date <= d2))
                   {
                        result.Add(item);
                   }
                   else if(DateTime.Compare(d1, d2) > 0 && (item.When.Date <= d1 && item.When.Date >= d2))
                    {
                        result.Add(item);
                    }
                   else if (DateTime.Compare(d1,d2) == 0 && d1.Date == item.When.Date)
                    {
                        result.Add(item);
                    }
                }   
            }

            return result;
        }

        public void writeList(ListBox lb, List<Measure> list)
        {
            lb.Items.Clear();
            var list2 = list.OrderBy(x => x.When).ToList();
            foreach (Measure item in list2)
            {
                lb.Items.Add(item);
            }
        }

        public double avg(ListBox l)
        {
            double db = 0;
            double s = 0;
            Measure m;
            foreach (object item in l.Items)
            {
                m = (Measure)item;
                if (m.Unit == "mg/dl")
                {
                    s += (double)m.Rate;
                }
                else if (m.Unit == "mmol/l")
                {
                    s += bl.mmol_to_mg(m.Rate);
                }
                db++;
            }
            
            return s / db;
        }
        
        public double min(ListBox lb)
        {
            double min = 1000;
            double current;
            foreach (object item in lb.Items)
            {
                Measure m = new Measure();
                m = (Measure)item;

                if(m.Unit == "mmol/l")
                {
                    current = bl.mmol_to_mg(m.Rate);
                }
                else
                {
                    current = m.Rate;
                }
                
                if(current < min)
                {
                    min = current;
                }
            }

            return min;
        }
        
        public double max(ListBox l)
        {
            double min = 0;
            double current;
            foreach (object item in l.Items)
            {
                Measure m = new Measure();
                m = (Measure)item;
                if (m.Unit == "mmol/l")
                {
                    current = bl.mmol_to_mg(m.Rate);
                }
                else
                {
                    current = m.Rate;
                }

                if (current > min)
                {
                    min = current;
                }
            }

            return min;
        }
    }
}
