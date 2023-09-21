using EmplyeeClerkManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeClerkManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowEmployeeDetails(new Clerk(1,"Albin",26,2000,400));
            ShowEmployeeDetails(new Manger(2, "Akash", 56, 2000, 100));
            ShowEmployeeDetails(new Clerk());
            Clerk clerk = new Clerk();
           

        }
        static void ShowEmployeeDetails(Employee employee) 
        {
            Console.WriteLine("------"+employee.GetType().Name);
            Console.WriteLine(employee.PrintDetails());
        }
    }
}
