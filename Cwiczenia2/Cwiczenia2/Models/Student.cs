using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenia2.Models
{
    public class Student
    {
        public string Email { get; set; }
        public string Imie { get; set; }

        private string _nazwisko;
        public string Nazwisko
        {
            get { return _nazwisko;  }
            set
            {
                if (value == null) throw new ArgumentException();
                _nazwisko = value;
            }
        }
    }
}
