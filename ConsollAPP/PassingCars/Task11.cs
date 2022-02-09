using System;

namespace ConsollAPP.PassingCars
{
    public class Task11
    {
        public static int solution(int[] A)
        {
            var lenght = A.Length;
            if (lenght < 0 || lenght > 1000000) throw new ArgumentOutOfRangeException();
            var lastcar = 0;
            var newcar = 0;

            foreach (var value  in A)
            {
                if (value == 1)
                {
                    newcar += lastcar;
                    if (newcar > 1000000000) return -1;
                }
                else
                    lastcar++;
            }

            return newcar;
        }

    }
}