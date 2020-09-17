using System;

namespace m_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] Matrix_test = new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            //int[,] Matrix_test = new int[,] { { 2, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };

            if (IsToeplitz(Matrix_test))
            {
                Console.WriteLine("This matrix is a toeplitz matrix.");
            }
            else
            {
                Console.WriteLine("This matrix is not a toeplitz matrix.");
            }
        }

        public static bool IsToeplitz(int[,] matrix)
        {
            if(matrix.GetLength(0)<matrix.GetLength(1))//M>N
            {
                for(int dimension1=0;dimension1<matrix.GetLength(0);dimension1++)
                {
                    for(int dimension0=0;dimension0<(matrix.GetLength(0)-1);dimension0++)//O(n^2)
                    {
                        if (matrix[dimension0, dimension1] != matrix[dimension0 + 1, dimension1 + 1])//左上和右下如果不相等
                        { return false; }
                    }
                }
                //全部对角线都相等
                return true;
            }
            //M<N
            else { return false; }
        }
    }
}
