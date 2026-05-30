using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationCSharpSln.CSharpFundamentals
{
    public class Inheritance : Program
    // To inherit the properties and methods of the parent class we need to use the keyword " : " followed by the name of the parent class
    {
        public static void Main(string[] args)
        {
            // For calling the method we need to create an object of the class
            Inheritance obj1 = new Inheritance();
            obj1.Setdata();
            obj1.Equation();

            B obj2 = new B();
            obj2.mrthod1();
            obj2.method2();
            Console.WriteLine("The name of the person is " + obj2.name);
        }
    }

    public class A
    {
        public string name = "Pragya";
        public void mrthod1()
        {
            Console.WriteLine("This is the method of class A");
        }
    }

    public class B : A
    {
        public void method2()
        {
            Console.WriteLine("This is the method of class B");
        }
    }
}
