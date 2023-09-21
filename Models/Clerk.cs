using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmplyeeClerkManager.Models
{
    internal class Clerk : Employee
    {
        public double Bonus { get; set; }
        public Clerk() {
            Console.WriteLine("default clerk print");
        }
        public Clerk(int id, string name, int age, int salary,double bonus):base(id,name,age,salary)
        {
            Bonus = bonus;
        }

        public override string PrintDetails()
        {
            return base.PrintDetails() + $"Bonus{Bonus}";
        }
    }
}
