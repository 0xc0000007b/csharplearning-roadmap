using System;

namespace ConsoleApplication3
{
    public delegate void TestDelegate(); // this delegate corresponds to all methods that accept nothing and return nothing
    // delegates are returnable and non-returnable
    public delegate int TestDelegate2(int a, int b);
    public class Delegates
    {
        private static TestDelegate _test = new TestDelegate(ShowMsg); // non-returnable delegate
        private static TestDelegate2 _testDelegate2 = new TestDelegate2(SumTwoInts); // returnable delegate

       public static void SomeMethod() // and now. if we invoke that method on Main method in class Program, were seeing message
        {
            _test();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            _testDelegate2(a,b);
            
        }
        public static void ShowMsg()
        {
            Console.WriteLine("test delegate");
        }

        public static int SumTwoInts(int a, int b)
        {
            
            int c = a + b;
            Console.WriteLine(c);
            return c;
        }

       
        
    }
}