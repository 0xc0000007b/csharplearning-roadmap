using System;

namespace ConsoleApplication3
{
    public class ClassesAnd300LayersOfAbstract // <- class is the main entity on your program
    {
        
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