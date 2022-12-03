using System;

namespace ConsoleApplication3
{
    public class LambdaExpressions
    {
        private int a = 33;
        private int b = 44;
        
        //regular method expression
        public void APlusB(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        
        // lambda method exp

        public void AddAToB(int a, int b) => Console.WriteLine(a + b); 
        // Lambda is most easyest calling to method, which have one string of code
        // public void ReturnInput(int a) => return a;
        // public void ReturnInput(int a) {return a}
        // public void ReturnInput(int a) { Console.Write("a");
    }
}