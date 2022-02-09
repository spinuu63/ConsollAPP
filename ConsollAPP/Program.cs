using System;
using ConsollAPP.BinaryGap;
using ConsollAPP.CyclicRotation;

namespace ConsollAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Raspunsul pentru task-ul nr.1
            int result1 = Task1.task1(1041);
            Console.WriteLine("Rezultatul task1: " + result1);
            
            // Raspunsul pentru task-ul nr.2
             int[]  A = {3, 8, 9, 7, 6};

             Console.Write("Our String is: \n");
             for (int i = 0 ; i < A.Length; i++) 
             {
                 Console.Write(A[i] + " ");
             }
            
             int[] result2 = Task2.solution(A, 3);
            Console.WriteLine(result2);
        }
    }
}