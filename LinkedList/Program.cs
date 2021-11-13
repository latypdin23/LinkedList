using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public static int[,] MatrixMult(int [,] A, int [,] B, int N, int H, int M)
        {
            int[,] result = new int[N, M];
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < M; j++)
                {
                    result[i, j] = 0;

                    for (var k = 0; k < H; k++)
                    {
                        result[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return result;
        }
        public static LinkedList<LinkedList<int>> MatrixMult(LinkedList<LinkedList<int>> A, LinkedList<LinkedList<int>> B, int N, int H, int M)
        {
            LinkedList<LinkedList<int>> result = new LinkedList<LinkedList<int>>();
           
            for (int i = 0; i < N; i++)
            {
                LinkedList<int> resRow = new LinkedList<int>();
                LinkedList<int> fromA = A.First();
                for (int j = 0; j < M; j++)
                {
                    int tmp = 0;
                    for (int k = 0; k < H; k++)
                    {
                        LinkedList<int> fromB = B.First();

                        int a = fromA.First(); int b = fromB.First();
                        tmp += a * b;

                        fromA.RemoveFirst(); fromA.AddLast(a);
                        fromB.RemoveFirst(); fromB.AddLast(b);
                        B.RemoveFirst(); B.AddLast(fromB);
                    }
                    resRow.AddLast(tmp);
                }
                result.AddLast(resRow);
                A.RemoveFirst(); A.AddLast(fromA);
            }

            return result;
        }
        static void ShowMatrix(double[,] matrix, int N, int M)
        {
            for(int i=0;i<N;i++)
            {
                for(int j=0;j<M;j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static void ShowMatrix(LinkedList<LinkedList<int>> matrix)
        {
            foreach (LinkedList<int> i in matrix)
            {
                foreach (int j in i)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            LinkedList<LinkedList<int>> A = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> B = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> Result = new LinkedList<LinkedList<int>>();

            int N=3,H=3,M = 3;
            Random random = new Random();
            
            for (int i = 0; i < N; i++)
            {
                LinkedList<int> temp = new LinkedList<int>();
                for (int j = 0; j < M; j++)
                {
                    temp.AddLast(random.Next(10));
                }
                A.AddLast(temp);
            }
            
            for (int i = 0; i < H; i++)
            {
                LinkedList<int> temp = new LinkedList<int>();
                for (int j = 0; j < M; j++)
                {
                    temp.AddLast(random.Next(10));
                }
                B.AddLast(temp);
            }
            Console.WriteLine("Матрица A:");
            ShowMatrix(A);
            Console.WriteLine("Матрица B:");
            ShowMatrix(B);
            
            Result = MatrixMult(A, B, N,H,M);
            Console.WriteLine("Матрица C = A * B:");
            ShowMatrix(Result);

            Console.ReadKey();
        }
    }
}
