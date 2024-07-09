using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr
{
    internal class TypeB:TypeA
    {
        private int H;

        public TypeB()
        {
            // H is"not inherited"
            // X is not inherited as "Private"
            // Y is not inherited as "Private"
            // Z is not inherited as "internal"
                    
        }
        public void Test()
        {
            TypeA obj = new TypeA();
           // obj.x = 1;    "x is private"
           // obj.x = 2;    "y is private"
              obj.Z = 3; // "z is internal"
        }
        public int B { get; set; }
        public TypeB(int _A , int _B):base(_A)
        {
            B = _B; 
        }
    }
}
