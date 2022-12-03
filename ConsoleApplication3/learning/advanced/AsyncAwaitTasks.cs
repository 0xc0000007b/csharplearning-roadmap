using System;
using System.Threading;
using System.Threading.Tasks; // That Library used the threading in your system
// read about threads in additional links on Readme

namespace ConsoleApplication3
{
    public class AsyncAwaitTasks
    {
        public async void TestAsyncMethod() // async is not synchro completing the methods in your programs 
        {
           await  Task.Run(() => // Task is the process, which you write and program wait, until complete this process  
            {
                Thread.Sleep(2000); // sleep time -> 2 sec
                Console.WriteLine("test Passed"); // this method has work when ending wait time 
            });
        } 
    }
}