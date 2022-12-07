using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;

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
                Console.WriteLine(i + testable.GetTestsCount());
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

    class TesTComparer : IComparer<Men>
    {
        public int Compare(Men x, Men y)
        {
            if (x.Age < y.Age) return -1;
            else if (x.Age > y.Age) return 1;
            return 0;
        }
    }

    public class SomePopularClassName
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }

    SomePopularClassName _popular = new SomePopularClassName()
    {
        Name = "Tyotya",
        SurName = "Motya",
        Age = 99,
        Company = "Vasyan From 5G"
    };

    SomePopularClassName _newClass = _popular;
    _newClass.Age = 33;
    _newClass.Name = "Vasyan";
    _newClass.SurName = "Pupovyan";
    Console.WriteLine($"newClass name: {_newClass.Name}");

    class Person : ICloneable
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return new Person()
            {
                Name = this.Name,
                Age = this.Age,
                Company = this.Company
            };
            Person p = new Person()
            {
                Name = "Igor",
                Age = 33,
                Company = "Igoryan inCorporated"
            };
            Person newPer = (Person)p.Clone();
            newPer.Age = 65;
            newPer.Name = "Jane";
            newPer.Company = "Some Company";
            Console.WriteLine($"person: {p.Name} {p.Company} {p.Age}");
            Console.WriteLine($"newPerson: {newPer.Name} {newPer.Company} {newPer.Age}");

        }
    }


    // ICloneable

    class Auto : ICloneable
    {
        public string Vin { get; set; }
        public string Mark { get; set; }
        public string Manufacterer { get; set; }

        public object Clone()
        {
            return new Auto()
            {
                Vin = this.Vin,
                Mark = this.Mark,
                Manufacterer = this.Manufacterer
            };

        }
    }
    Auto a = new Auto()
    {
        Vin = "gfyeygeuhfij212oej",
        Manufacterer = "Mercedes",
        Mark = "G-150"
    };
    Auto newAuto = (Auto)a.Clone();
    newAuto.Manufacterer = "Vasyan";
    newAuto.Mark = "v-300";
    newAuto.Vin = "123";
    Console.WriteLine($"person: {a.Vin} {a.Manufacterer} {a.Mark}");
    Console.WriteLine($"newPerson: {newAuto.Mark} {newAuto.Manufacterer} {newAuto.Vin}");
    


}