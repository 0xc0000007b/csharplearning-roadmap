using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public class Generics
    {
        private static Random r = new Random();
        public static void GenericsTest()
        {
            //List - Список
            List<int> nums = new List<int>(10);
            nums.Add(r.Next(100));
            nums.Add(r.Next(100));
            nums.Add(r.Next(100));
            nums.Add(r.Next(100));
            nums.Add(r.Next(100));
            nums.Add(r.Next(100));
            nums.Add(r.Next(100));
            nums.Add(r.Next(100));
            nums.Add(r.Next(100));
            
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i]);
            }
            // -> 66 88 85 1 8 37 37 69 48
            
            
            // Queue -  очередь.uses algorithm FIFO - First in First Out 
            Queue<string> qu = new Queue<string>(5);
                
            qu.Enqueue("Vasya"); 
            // method Enqueue adding the element to the queue
            qu.Enqueue("Petya");
            qu.Enqueue("Dima");
            qu.Enqueue("Olga");
            
            foreach (var q in qu) 
                //  queue gets over by foreach
            {
                Console.Write("\n" +q + " ");
            } 
            // -> Vasya Petya Dima Olga

            Console.Write("На прием идет " + qu.Dequeue());
            // now we explore who going to reception on now
            // -> Going to the reception Vasya
            // method Dequeue() finds element and delete these element from the queue 
            //now we explore who the next in queue
            Console.Write("\nNext in Queue " + qu.Peek());
            // now we explore who going to reception next
            // Next in Queue Petya
            qu.Clear(); 
            // clear the queue
            
            // Stack<>();
            Stack<int> numbers = new Stack<int>();
            // now we initialize Stack
            numbers.Push(123);
            // now we adding element to the stack. uses algorithm LIFO - last in First Out 
            numbers.Push(33);
            numbers.Push(12);
            numbers.Push(1111);
            numbers.Push(1000);
            numbers.Peek(); 
            // now we explore which element on top in stack
            while (numbers.Count > 0)
            {
                Console.WriteLine("nwxt number in stack: " + numbers.Pop()); 
                // method Pop has removing element from the collection
                
                
            }
            
            // Dictionary - словари. uses key and value 
            Dictionary<string, string> carMark = new Dictionary<string, string>();
            //but dictionary is not necessary must contains coincided types
            //Dictionary<int, string> carMark = new Dictionary<int, string>();
            //Dictionary<string, int> carMark = new Dictionary<string, int>();
            //Dictionary<bool, int> carMark = new Dictionary<bool, int>();
            //Dictionary<string, bool> carMark = new Dictionary<string, bool>();
            
            carMark.Add("Toyota", "Octavia");
            // Toyota is key, Octavia is value
            
            carMark.Add("Lada", "largus"); 
            carMark.Add("Renault", "Sandera");
            
            if (carMark.ContainsKey("Toyota"))
            // check if key contains word Toyota, we get his value    
                Console.WriteLine(carMark["Toyota"]);
                // returns Octavia, because Toyota is a key 

                foreach (var car in carMark)
                {
                    Console.WriteLine($"car - {car.Key} value - {car.Value}");
                }
                // these cycle has returns car - Toyota value - Octavia car - Lada value - largus car - Renault value - Sandera
                
                // getting over by key
                foreach (var key in carMark.Keys)
                {
                    Console.WriteLine($"car - {key}");
                } 
                // these cycle returns car - Toyota car - Lada car - Renault
                
                carMark.Remove("Lada"); // removing an element from the collection
                foreach (var car in carMark)
                {
                    Console.WriteLine($"car - {car.Key} value - {car.Value}");
                }
                // these cycle has returns car - Toyota value - Octavia car - Renault value - Sandera

        }

    } 
}
