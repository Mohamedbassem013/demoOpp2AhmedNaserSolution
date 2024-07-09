using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int _X , int _Y)
        {
            X = _X;
            Y = _Y;
        }

        public override string ToString() 
        {
            return $"X: {X} \nY:{Y}";
        }

        public virtual int Product()
        {
            return X * Y;
        }
    }
}
