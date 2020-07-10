using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Basics
{
    class Program
    {
        static void Main()
        {
            A objA = new A();   //Can only use objA
            objA.AMethod();

            B objB = new B();   //Can both
            objB.BMethod();
            objB.AMethod();
            

            A obj = new B();    //Superclass = subclass is allowed
            obj.AMethod();      //Can only use the method in A, but since B overrides it will call the method in B
                                //Specifies that this is a B object
                                //B obj =  A();     Cannot do this. Subclass = superclass is not allowed.


            //Casting
            ((B)obj).BMethod(); //Can call both methods
            ((B)obj).AMethod(); //Calls methodA in B
        }
    }

    //Note: Behaviour/Property = Value     Example int number = 15;   A obj = new B();
    class A
    {
        public virtual void  AMethod()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
        public override void AMethod()
        {
            Console.WriteLine("ckass b overrides methodA");
        }
    }
}
