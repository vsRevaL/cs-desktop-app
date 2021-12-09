using System;
using System.Collections.Generic;

#nullable disable

namespace app1.Model
{
    public partial class Patient
    {
        public Patient()
        {
            Measures = new HashSet<Measure>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Measure> Measures { get; set; }
    }
}
