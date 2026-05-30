using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationCSharpSln.CSharpFundamentals
{
    public class Polymorphism
    {
        // Polymorphism is the ability of an object to take on many forms. It is the ability of a class to provide different implementations of a method. It is achieved through method overloading and method overriding.
        // Method overloading is the ability of a class to have multiple methods with the same name but different parameters. It is achieved by changing the number of parameters or the type of parameters.

        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        // param - is a keyword that is used to specify a parameter that takes a variable number of arguments. It is used in method overloading to allow a method to take a variable number of arguments. It is used in the method signature to indicate that the method can take a variable number of arguments.
        static double Multiply(params double[] numbers)
        {
            double result = 1;
            foreach (double number in numbers)
            {
                result *= number;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2, 3, 4));

            A obj1 = new A();
            obj1.Display();
            B obj2 = new B();
            obj2.Display();
        }
    }
    // Method overriding is the ability of a class to provide a different implementation of a method that is already provided by its parent class. It is achieved by using the keyword "override" in the child class and the keyword "virtual" in the parent class.

    class X
    {
        public virtual void Display()
        {
            Console.WriteLine("This is the method of class A");
        }
    }
    class Y : X
    {
        public override void Display()
        {
            Console.WriteLine("This is the method of class B");
        }
    }
}
