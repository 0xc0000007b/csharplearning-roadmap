using System;
using static System.Math;
namespace ConsoleApplication3.learning.basics
{
    public class MathOperations
    {
        // summing the numbers
        // for easyest find the Pi microsoft create the Math library 
        private int a = 5; // initialize field the type of int with name a, she was equals the 5
        private int b = 6; // initialize field the type of int with name a, she was equals the 6
        
        
        // Methods i returns later for this theme
        public  void Sum(int a,int b)
        {
            Console.WriteLine(a + b); // this standard sharp method for output in console
        }
        public  void Parity(int a,int b)
        {
            Console.WriteLine(a - b); // this standard sharp method for output in console
        }
        public  void Multiply(int a,int b)
        {
            Console.WriteLine(a - b); // this standard sharp method for output in console
        }
        public  void Devide(int a,int b)
        {
            Console.WriteLine(a - b); // this standard sharp method for output in console
        }
        public  void PercentBy(int a,int b)
        {
            Console.WriteLine(a % b); // this standard sharp method for output in console
        }

        public void GetPI()
        {
            Console.WriteLine(Math.PI);
        }
    }
}