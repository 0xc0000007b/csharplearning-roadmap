using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApplication3
{
    // read more about interfaces(precc ctrl and click on link): https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces
    
    public interface ITestable
    {
        string GetTestsCount();
        
    }

    interface ITestCounter
    {
        void TestCounter(ITestable testable);
    }
    
    
    public class TestCounting : ITestCounter
    {
        public void TestCounter(ITestable testable)
        {
            int test = 0;
            for (int i = test; i < 500 && i > -1; i++)
            {
                Console.WriteLine(i + testable.GetTestsCount()) ;
            }
        }

        public class TestReader : ITestable
        {
            public string GetTestsCount()
            {
                return " Tests passed";
            }
        }
    }
    // IEnumerator
    public class IEnumeratorTest
    {
        public static void SomeMethod()
        {
            int[] test = new[] { 5, 44, 87, 908, 666 };
            IEnumerator numerator = test.GetEnumerator();
            while (numerator.MoveNext())
            {
                int i = (int)numerator.Current;
                Console.WriteLine(i);
            }
            numerator.Reset();
            
        }
        
    }
    //IComparable, IComparator
    class Men : IComparable
    {
        public Men()
        {
            
        }

        public Men(int age, double height, double weight)
        {
            this._age = age;
            this._height = height;
            this._weight = weight;
        }
        private int _age;
        private double _height;
        private double _weight;
        
        public int Age => _age;
        public double Height => _height;
        public double Wieght => _weight;
        
        public int CompareTo(object obj)
        {
            Men m = obj as Men;

            if (m != null)
            {
                if (this._age < m._age) return 1;
                else if (this._age > m._age) return -1;
                else return 0;
            }
            else
            {
                throw new Exception("Its the fucking shit! Param must be have type of Men");
            }
        }
    }
}