using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Patient
    {
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public bool Follow { get; private set; }
        public string age { get; set; }
        public string Phone { get; set; }
        public string address { get; set; }
        public Patient(string name, Gender gender, bool follow , string Age , string phone, string Address)
        {
            Name = name;
            Gender = gender;
            Follow = follow;
            age = Age;
            Phone = phone;
            address = Address;

        }
        public override string ToString()
        {
            return Name;
            {



            }


        }
    }
}
