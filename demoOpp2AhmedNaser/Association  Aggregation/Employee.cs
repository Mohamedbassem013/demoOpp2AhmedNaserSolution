using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr.Association__Aggregation
{
     class Employee
     {
        public int Id { get; set; }
        public int? Age { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public void MyFun01()
        {
            Console.WriteLine("I am Employee");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"Employee: Id:{Id} , Name:{Name} , Age: {Age}");
        }
     }
    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("I am FullTime Employee");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"FullTime Employee: Id:{Id} , Name:{Name} , Age: {Age} , Salary :{Salary}");
        }
    }
    class partTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("I am FullTime Employee");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"PaetTime Employee: Id:{Id} , Name:{Name} , Age: {Age} , HourRate :{HourRate}");
        }
    }
}
