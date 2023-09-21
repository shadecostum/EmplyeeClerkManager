using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeClerkManager.Models
{
    internal class Manger : Employee
    {
        public double Incentive { get; set; }
        public Manger() {
            Console.WriteLine("default manager");
        }

        public Manger(int id, string name, int age, int salary,double incentive):base(id, name, age, salary)
        {
            Incentive = incentive;
        }


        public override string PrintDetails()
        {
            return base.PrintDetails() + $"Bonus{Incentive}";
        }
    }
}
