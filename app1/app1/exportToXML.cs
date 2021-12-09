using app1.Model;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace app1
{
    static class exportToXML
    {   
        static string fn;
        public static void InsertData(string username, List<Measure> ms)
        {
            Ticket2XmlList list = new Ticket2XmlList();
            list.data = new List<Ticket2Xml>();

            foreach (Measure item in ms)
            {
                if(item.Username == username)
                {
                    Ticket2Xml m = new Ticket2Xml();
                    m.When = item.When.ToString();
                    m.Daytime = item.Daytime;
                    m.Rate = (decimal)item.Rate;
                    m.Unit = item.Unit;
                    m.Critical = item.Critical;
                    list.data.Add(m);
                }
            }

            fn = username + ".xml";

            if (File.Exists(fn))
            {
                File.Delete(fn);
            }

            XmlSerializer ser = new XmlSerializer(typeof(Ticket2XmlList));
            using (StreamWriter sw = new StreamWriter(fn))
            {
                ser.Serialize(sw, list);
            }

            /* using (XmlWriter xw = XmlWriter.Create(fn))
             {
                 xw.WriteStartDocument();

                 foreach (Patient p in db.Patients.Include(x=>x.Measures))
                 {
                     if (p.Username == username)
                     {
                         string s1 = p.FirstName.ToString();
                         string s2 = p.Lastname.ToString();
                         xw.WriteStartElement(s1 + s2);
                         foreach (Measure m in p.Measures)
                         {
                             xw.WriteStartElement("Measure");

                                xw.WriteElementString("When", m.When.ToString());
                                xw.WriteElementString("Daytime", m.Daytime.ToString());
                                xw.WriteElementString("Rate", m.Rate.ToString());
                                xw.WriteElementString("Unit", m.Unit.ToString());
                                xw.WriteElementString("Critical", m.Critical.ToString());

                             xw.WriteEndElement();
                         }
                         xw.WriteEndElement();
                         break;
                     }
                 }

                 xw.WriteEndDocument();
             }*/
        }
    }
}
