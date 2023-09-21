using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeClerkManager.Models
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age{ get; set; }
        public int Salary { get; set; }
        
        public Employee() {
            Console.WriteLine("default emplyee");
        }

        public Employee(int id, string name, int age, int salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual string PrintDetails()
        {
            return $"Emplyee id :{Id}\n" +
                $"Emplyee Name :{Name}\n" +
                $"Emplyee age :{Age}\n" +
                $"Emplyee id :{Salary}\n";
        }
    }
}
