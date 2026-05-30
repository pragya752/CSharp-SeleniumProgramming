using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationCSharpSln.CSharpFundamentals
{
    public class Constuctor
    {
        // constructor is a special method that is used to initialize the object of the class. It is called when the object of the class is created. It has the same name as the class and does not have any return type.
        public string name;
        public int age;

        public Constuctor(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("The name of the person is " + name);
            Console.WriteLine("The age of the person is " + age);
        }

        public static void Main(string[] args)
        {
            Constuctor obj1 = new Constuctor("Pragya", 22);
            obj1.display();
        }

    }
}
