using System;
using ConsollAPP.BinaryGap;
using ConsollAPP.CyclicRotation;
using ConsollAPP.PassingCars;

namespace ConsollAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Raspunsul pentru task-ul nr.1
            // int result1 = Task1.task1(1041);
            // Console.WriteLine("Rezultatul task1: " + result1);
            //
            // // Raspunsul pentru task-ul nr.2
            //  int[]  A = {3, 8, 9, 7, 6};
            //
            //  Console.Write("Our String is: \n");
            //  for (int i = 0 ; i < A.Length; i++) 
            //  {
            //      Console.Write(A[i] + " ");
            //  }
            //
            //  int[] result2 = Task2.solution(A, 3);
            // Console.WriteLine(result2);
            
            // Raspunsul pentru task-ul nr.11
            int result11 = Task11.solution(new[] {0, 1, 0, 1, 1});
            Console.WriteLine("Raspunsul task-ului 11 este: " + result11);
        }
    }
}