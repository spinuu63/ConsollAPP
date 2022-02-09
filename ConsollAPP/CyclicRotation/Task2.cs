namespace ConsollAPP.CyclicRotation
{
    public class Task2
    {
        public static int[] solution(int[] A, int K)
        {
            
            if(A.Length == 0 || K == 0)
            {
                return A;
            }

            int[] B = new int[A.Length];

            B[0] = A[A.Length - 1];

            for (int j = 0; j < A.Length - 1; j++)
            {
                B[j + 1] = A[j];
            }

            if (K > 1)
            {
                return solution(B, K - 1);
            }
            else
            {
                return B;
            }
        } 
    }
}