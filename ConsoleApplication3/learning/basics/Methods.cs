using System;

namespace ConsoleApplication3.learning.basics
{
    
    public class Methods
    {
        // void Method()
        // {
        //     
        // }
        // that is method in c#, he have access modificator(optional), name -> Method and returning type -> void, and the input parameterts 

        public void TestMethod()
        {
            Console.WriteLine("that is void method");
        }
        public int TestMethodWithReturningInt()
        {
            int a = 5;
            int b = 5;
            int res = a + b;
            Console.WriteLine("that method returns the int (res). " + "\n" + "res = " + res);
            return res; // return a + b; 
        }
        
        //access modificators private, public, protcted
        //public ->  you can invoke  and edit in any classes
        // private -> you can not invoke the method in another classes
        //protected -> you can not use and edit method on another class 
        
    }
}