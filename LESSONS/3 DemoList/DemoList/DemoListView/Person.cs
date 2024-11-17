using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListView
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address {  get; set; }

        public Person() 
        {
            this.Id = 1;
            this.Name = "Demo Name";
            this.Address = "Phnom Penh";
        }

        public Person(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
