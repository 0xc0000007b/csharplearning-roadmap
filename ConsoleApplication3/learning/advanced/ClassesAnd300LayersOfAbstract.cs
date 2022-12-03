using System;

namespace ConsoleApplication3
{
    public class ClassesAdnd300LayersOfAbstract // <- class is the main entity on your program
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
}