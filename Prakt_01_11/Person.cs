using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_01_11
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Person(string firstname,string lastname, string phone) 
        {
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
        }

    }
}
