using System;
using System.Collections.Generic;

#nullable disable

namespace app1.Model
{
    public partial class Measure
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime When { get; set; }
        public string Daytime { get; set; }
        public double Rate { get; set; }
        public string Unit { get; set; }
        public string Critical { get; set; }

        public virtual Patient UsernameNavigation { get; set; }

        public override string ToString()
        {
            return Id + " " + When.ToString("yyyy-MM-dd") + " " + Daytime + " " +
                               Rate + " " + Unit + " " + Critical;
        }
    }
}
