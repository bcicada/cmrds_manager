using System;
using System.Collections.Generic;
using System.Text;

namespace cmrds_manager.Config
{
    public class Group
    {
        // Properties.
        private List<Person> _list;

        // Constructor.
        public Group()
        {
            List = new List<Person>();
        }

        // Methods.
        public List<Person> List { get => _list; set => _list = value; }
    }
}
