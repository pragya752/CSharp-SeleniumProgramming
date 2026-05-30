using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationCSharpSln.CSharpFundamentals
{
    public class Program
    {

        public void Equation()
        {
            Console.WriteLine("Enter two numbers : ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Square root of a number is : " + c);
        }

        public void Setdata()
        {
            Console.WriteLine(" I am in parent class. ");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name : ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is : " + name + "and age is : " + age);
            // Or we can write it as 
            Console.WriteLine($"Your name is {name} and age is {age}.");

            // For calling the method we need to create an object of the class
            Program obj1 = new Program();
            obj1.Equation();

            //************** Type casting ****************
            double x = 10.5;
            int y = Convert.ToInt32(x); // Explicit type casting
            Console.WriteLine(y.GetType());

            String str = Convert.ToString(x);
            Console.WriteLine(str.GetType());

            String z = "true";
            bool b = Convert.ToBoolean(z);
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);


            //************** Math ****************
            double a = 3;
            double pow = Math.Pow(a, 3);
            double sqrt = Math.Sqrt(pow);
            double abs = Math.Abs(-5);
            double round = Math.Round(3.5);
            double floor = Math.Floor(3.5);
            double ceil = Math.Ceiling(3.5);
            double max = Math.Max(3, 5);
            double min = Math.Min(3, 5);

            //************** String ****************
            String fullName = "Pragya Vishwakarma";
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.ToLower());
            String prefix = fullName.Insert(0, "Ms. ");
            Console.WriteLine(prefix);
            Console.WriteLine(fullName.Length);
            String firstName = fullName.Substring(0, 6);
            Console.WriteLine(firstName);

            //************** Logical Operator ****************
            double temp = 60;
            if (temp >= 10 && temp <= 30)
            {
                Console.WriteLine("The weather is pleasant.");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("Don't go outside.");
            }

            //************** Loops ****************
            String name1 = " ";
            while (name1 == " ")
            {
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            foreach (char c in fullName)
            {
                Console.WriteLine(c);
            }

            //************** Arrays ****************
            //Array is a collection of similar data type. It is used to store multiple values in a single variable. It is a fixed size data structure. It is indexed based data structure. The index starts from 0.
            String[] Employees = new String[4];
            Employees[0] = "Pragya";
            Employees[1] = "Vishwakarma";
            Employees[2] = "Suman";
            Employees[3] = "Sumanth";
            Employees[4] = "Sumanth"; // This will give an error because the size of the array is 4 and we are trying to access the index 4 which is out of range.

            // Or we can initialize the array like this
            String[] Employees1 = { "Pragya", "Vishwakarma", "Suman", "Sumanth" };
            for (int i = 0; i < Employees1.Length; i++)
            {
                Console.WriteLine(Employees1[i]);
            }

            foreach (String employee in Employees1)
            {
                Console.WriteLine(employee);
            }

            //************** Multi-dimensional Arrays ****************
            String[,] Employees2 =
            {
                { "Pragya", "Vishwakarma" },

                { "Suman", "Sumanth" }
            };

            //*************** List ****************
            List<String> food = new List<String>();
            food.Add("Pizza");
            food.Add("Burger");
            food.Add("Pasta");
            food.Insert(0, "Fries");
            food.Remove("Burger");
            food.IndexOf("Pasta");
            food.Sort();
            food.Reverse();
            food.Count();
            food.Clear();

            //************** Conditional Operator ****************
            // Conditional operator is a ternary operator that takes three operands. It is used to evaluate a condition and return a value based on the condition. The syntax of the conditional operator is : condition ? value if true : value if false
            double temperature = 25;
            String weather = temperature >= 30 ? "Hot" : "Pleasant";
            Console.WriteLine(weather);

            //************** Exception Handling ****************
            // Exception handling is a mechanism to handle the runtime errors. It is used to handle the exceptions that occur during the execution of the program. The syntax of the exception handling is : try { // code that may throw an exception } catch (ExceptionType e) { // code to handle the exception } finally { // code that will be executed regardless of whether an exception is thrown or not }
            try
            {
                Console.WriteLine("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number is : " + num);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
