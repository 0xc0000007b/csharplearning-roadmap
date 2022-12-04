using System;
using System.Linq.Expressions;

namespace ConsoleApplication3.learning.basics
{
    public class ArraysAndCycles
    {
        // int[] arr -> intialize array of ints, arrays there are 1 dimension and more dimensions
        // string[,] -> 2D array of string
        // double[][] -> stepped array of int
        // go to use the arrays
        // you can be resize arrays.  C# contains standard method for arrays: Arrays.Resize(ref array array, size new size)<
        // but we realize us own method for these task
        public void CreateArray() // 1d arrays
        {
            Console.WriteLine("line array");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i] = new Random().Next(100);
             Console.Write(arr[i] + " ");
            }
            int a = 0; 
            int b = 0; 
            int c = 0; 
            while (a < 20)
            {
                arr[b] = c; // write numbers i array.
                Console.Write(arr[b] + " ");
                c++;
                a++; // cycle counter.
                
            }

            AsyncAwaitTasks async = new AsyncAwaitTasks();


        }
        public int[,] Create2DArray(int cols, int rows)
        {
            Console.WriteLine("2d array -> matrix");
            int[,] arr = new int[cols, rows];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) // GetLength method has checking that matrix by horizontal and vertical position
                {
                    arr[i, j] = new Random().Next(0,100);
                    Console.Write(arr[i,j] + "\t");
                } // cycle for -> check the array by i and j
                Console.WriteLine();
            }
            return arr;
        }

        public void ResizeArray(ref int[] array, int newSize) // we are resize us own array by these method
        {
            int[] newArray = new int[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++) // sort out all elements in all us arrays 
            {
                newArray[i] = array[i]; // rewrite indexes
            }

            array = newArray; // newArray has reffered to array
        }
        // 3D Array -> [,,], 4D -> [,,,], 5D -> [,,,,] and etc
        public void CreateSteppedArray()
        {
            Console.WriteLine("stepped array");
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[4];
            arr[2] = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = new Random().Next(100);
                    Console.Write(arr[i][j] + "\t");
                }

                
                Console.WriteLine();
            }
        }

        public void ForEachTest()
        {
            string[] arr = new[] { "test", "arr", "hello" };
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}