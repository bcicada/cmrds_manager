using System;
using System.Collections.Generic;
using System.Text;

namespace cmrds_manager.Config
{
    public class Person
    {
        // Properties.
        private string _name,_firstname,_division;
        private int _seniority;
        private bool _staff;

        // Constructor.
        public Person(string name, string firstname, string division, int seniority, bool staff)
        {
            Name = name;
            Firstname = firstname;
            Division = division;
            Seniority = seniority;
            Staff = staff;
        }
        
        // Methods.
        public string Name { get => _name; set => _name = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Division { get => _division; set => _division = value; }
        public int Seniority { get => _seniority; set => _seniority = value; }
        public bool Staff { get => _staff; set => _staff = value; }
    }
}
