using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr
{
    internal class TypeC :TypeB
    {
        public int C { get; set; }

        public TypeC(int _A , int _B , int _C):base (_A , _C)
        {
            C = _C;   
        }

        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [GrandChild]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeA : A= {A}, B ={B} , C= {C} ");
        }
    }
}
