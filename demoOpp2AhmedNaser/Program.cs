using demoOpp2AhmedNasr.Association__Aggregation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOpp2AhmedNasr
{
    class prgram
    {
        #region PolyMorphism -> 1. Funcation Oveloading
        public static int Sum(int X , int Y , int Z)
        {
            return X + Y + Z;
        }
        public static double Sum(double X, double Y)
        {
            return X + Y ;
        }
        public static double Sum(double X, int Y)
        {
            return X + Y ;
        }
        public static double Sum(int X, double Y)
        {
            return X + Y;
        }
        #endregion

        public static void ProcessEmployee(FullTimeEmployee employee) 
        {
            if(employee is not null)
            {
                employee.MyFun01();
                employee.MyFun02();
            }
        }
        static void Main(string[] args)
        {
            #region Class
            //Car C1;
            //C1 = new Car(123 , "Kia cerator 2024" ,220);
            //C1 = new Car(888, "Renault Megane 2024");
            //Console.WriteLine("*********************");
            //Console.WriteLine(C1.ToString());
            #endregion

            #region inheritance
            Child child = new Child(1, 2, 3);
            //child.X = 11;
            //child.Y = 22;
            //child.Z = 33;

            //Console.WriteLine(child.ToString());
            //Console.WriteLine("------------------");
            //Console.WriteLine($" Product = {child.Product()}"); //product = 6 
            #endregion

            #region Access Modifer
            //TypeA obj = new TypeA();
            //obj.X = 10; Invalid --> due to its Protection Level "X is Private"
            //obj.Y = 20; Invalid --> due to its Protection Level "X is internal"
            //obj.Z = 30;
            #endregion

            #region PolyMorphism -> 1.Funcation Oveloading
            //int Result = Sum(1,2,3);
            //Console.WriteLine($"Sum = {Result}");
            //Console.WriteLine();
            //Console.WriteLine("Ahmed");
            //Console.WriteLine('A');
            //Console.WriteLine(4);
            //Console.WriteLine(5.5F);
            //Console.WriteLine(5.5);
            //Console.WriteLine(5.5M);
            #endregion

            #region PolyMorphism -> 2.Funcation Overriding
            //TypeA typeA = new TypeA(1);
            //typeA.A = 11;
            //typeA.MyFun01();// "I am Base [Parent]"
            //typeA.MyFun02(); //TypeA : A= 11

            //TypeB typeB = new TypeB(1,2);
            //typeA.A = 11;
            //typeA.MyFun01();// "I am Base [Parent]"
            //typeA.MyFun02(); //TypeA : A= 11 
            #endregion

            #region Binding
            //Binding is a Behaviour
            //Reference From Parent = object From Child

            //TypeA RefBase = new TypeB(1, 2);
            //RefBase.A = 11;
            // RefBase.B = 22;

            //RefBase.MyFun01();// "I am Base [Parent]"
            // 2.1 Static Binding [Early Binding]
            //Compiler Will Bind Funcation Call Based On Reference Not Object
            //at Compilation
            //RefBase.MyFun02(); //TypeB : A= 11 , B = 2
            // 2.1 Dynamic Binding [Late Binding]
            //CLR Will Bind Funcation Call Based On Object Not Reference
            //at RunTime

            #endregion

            #region Not Binding
            //TypeA typeA;
            //typeA = new TypeA(1);
            //typeA = new TypeB(1, 2);
            //typeA = new Typec(1,2,3);

            //TypeB typeB = (TypeB) typeA;
            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);


            #endregion

            #region Binding is a Behaviour

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "Ahmed",
            //    Age = 23,
            //    Salary = 5_000
            //};
            //ProcessEmployee(fullTimeEmployee);

            //partTimeEmployee partTimeEmploye = new partTimeEmployee()
            //{
            //    Id = 20,
            //    Name = "Yassmin",
            //    Age = 28,
            //    HourRate = 120
            //};
            //ProcessEmployee(partTimeEmploye); 
            #endregion

            #region More P[ractice On Binding 
            //TypeA typeA = new TypeC(1,2,3);
            //typeA.A = 11;
            ////typeA.B = 22;
            ////typeA.C = 33;

            //typeA.MyFun01();
            //typeA.MyFun02();


            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 11;
            //typeB.B = 22;
            ////typeB.C = 33;

            //typeB.MyFun01();
            //typeB.MyFun02();

            //TypeA typeA1 = new TypeE(1, 2,3,4,5); //InDirect parent
            //TypeB typeB1 = new TypeE(1, 2,3,4,5); //InDirect parent
            //TypeC typeC1 = new TypeE(1, 2,3,4,5); //InDirect parent
            //
            //typeA1.MyFun02(); //TypeC : A = 1 , B = 2 , C = 3
            //typeB1.MyFun02(); //TypeC : A = 1 , B = 2 , C = 3
            //typeC1.MyFun02(); //TypeC : A = 1 , B = 2 , C = 3
            //
            //Console.WriteLine("After Break The Chain");
            //
            //TypeD typeD = new TypeE(1,2,3,4,5); //Direct parent
            //typeD.MyFun02(); // TyprE : A = 1 , B = 2 , C = 3 , D = 4, E = 5

            #endregion
        }   
    }
}