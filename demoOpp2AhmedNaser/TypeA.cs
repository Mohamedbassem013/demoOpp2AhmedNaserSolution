using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr
{
    internal class TypeA
    {
        private int H;
        private protected int X; //private
        protected int Y;        //private
        internal protected int Z; //internal
        public int A { get; set; }
        public TypeA()
        {
            
        }
        public TypeA(int _A)
        {
            A = _A;
        }
        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A= {A} ");
        }
    }
}
