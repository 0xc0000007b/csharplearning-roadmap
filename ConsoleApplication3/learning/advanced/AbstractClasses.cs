using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication3
{
    public class AbstractClasses // <- class is the main entity on your program
    {
        private static int test = 1;
        private static void CWL123() => Console.Write(test);
    }
    
    // abstract classes

    public abstract class Test
    {
        public abstract void WriteText();
    }

    public class TestForClass : Test
    {
        public override void WriteText()
        {
            Console.Write("All Tests Passed");
        }
    }

    public abstract class Weapon
    {
        public abstract void Fire();
    }
    
    
    public class Helicopter : Weapon
    {
        public override void Fire()
        {
            Console.Write("I end of flying and ready to Fire");
        }
    }
    
    public class Tank : Weapon
    {
        public override void Fire()
        {
            Console.Write("boom");
        }
    }
}