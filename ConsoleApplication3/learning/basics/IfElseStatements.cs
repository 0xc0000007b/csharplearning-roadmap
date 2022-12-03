using System;

namespace ConsoleApplication3.learning.basics
{
    public class IfElseStatements
    {
        // i make these clas for test the If/Else/Else if statements and logical operators
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());

        public void UselessMethod(int a, int b)
        {
            if( a > b) Console.WriteLine("A above B");
            else if (a < b && b > a ) Console.WriteLine("A bellow B"); // && equivalent and 
            else if (a == b || b == a) Console.WriteLine("A equals B"); // operator == equivalent =, || -> or 
            else if (a != b) Console.WriteLine("A not equals B"); // operator  != equivalent not equals
            else Console.WriteLine("A as is B");
        }
    }
}