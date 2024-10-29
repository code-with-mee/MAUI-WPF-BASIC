using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_DatagridView
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public Student() { }
        public Student(int id, string name, string phone, string address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
        }
    }
}
