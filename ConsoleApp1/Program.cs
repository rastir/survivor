using System;
using System.Collections.Generic;

/// <summary>
/// Матрица: Вращение
/// </summary>
///
/*
К сожалению, никто не может объяснить, что такое Матрица.
Ты должен сам увидеть это.

На вход поступает Матрица размером MxN:

1 2 3 4 5 6
2 3 4 5 6 7
3 4 5 6 7 8
4 5 6 7 8 9

Ты должен научиться вращать Матрицу относительно её центра по часовой стрелке.

Например, вращение на один шаг:

2 1 2 3 4 5
3 4 3 4 5 6
4 5 6 7 6 7
5 6 7 8 9 8

Функция

void MatrixTurn(string Matrix[], int M, int N, int T)

получает на вход (по ссылке) массив строк(M строк, каждая длиной N; M >= 2, N >= 2), и вращает его относительно центра по часовой стрелке на T шагов (T >= 1), как описано выше.
То есть результат поворота (повёрнутая матрица) оказывается в исходном массиве Matrix, переданном в функцию по ссылке как аргумент.

Минимальное значение из чисел M, N обязательно чётно.

Пример вызова:

MatrixTurn(["123456", "234567", "345678", "456789"], 4,6, 3)

*/
#region 
///Золота: 1567$ +
//вилка цены: 4400 - 5600 руб.

namespace Level1Space
{
    public static class Level1
    {
        public static void MatrixTurn(string[] Matrix, int M, int N, int T)
        {
            int[,] Array_Matrix = new int[M, N];
            int[,] Array_Matrix_Copy = new int[M, N];

            int number = 1;
            for (int i = 0; i < M; i++)
            {
                string word = Matrix[i];
                word.ToCharArray();

                for (int j = 0; j < N; j++)
                {
                    Array_Matrix[i, j] = Convert.ToInt32(word[j].ToString());
                }
            }

            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Array_Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < Array_Matrix.GetLength(1); j++)
            {
                for (int i = Array_Matrix.GetLength(0) - 1; i >= 0; i--)
                {
                    Console.Write("{0}\t", Array_Matrix[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < M; i++) 
            {
                for (int j = 0; j < N; j++)
                {
                    //if ((N % 2 != 0) && (M % 2 == 0))
                    //Matrix[i] += Array_Matrix[i, j];
                    if (i == 0 && j == 0)
                        Array_Matrix_Copy[i, j] = Array_Matrix[i + 1, j];
                    else if (i == 0 && j != 0)
                        Array_Matrix_Copy[i, j] = Array_Matrix[i, j - 1];

                    else if (i == M - 1 && j == N - 1)
                        Array_Matrix_Copy[i, j] = Array_Matrix[i - 1, j];
                    else if (i == M - 1 && j != N - 1)
                        Array_Matrix_Copy[i, j] = Array_Matrix[i, j + 1];

                    else if (j == 0 && i != M - 1)
                        Array_Matrix_Copy[i, j] = Array_Matrix[i + 1, j];
                    else if (j == N - 1 && i != 0)
                        Array_Matrix_Copy[i, j] = Array_Matrix[i - 1, j];

                    else if ((j <= Math.Floor((decimal)(Array_Matrix.GetLength(1) / 2))) && (i <= Math.Ceiling((decimal)(Array_Matrix.GetLength(0) / 2))))
                        Array_Matrix_Copy[i, j] = Array_Matrix[i + 1, j];
                    else if ((j <= Math.Floor((decimal)Array_Matrix.GetLength(1) / 2)) && (i > Math.Ceiling((decimal)Array_Matrix.GetLength(0) / 2)))
                        Array_Matrix_Copy[i, j] = Array_Matrix[i, j + 1];

                    else if ((j > Math.Floor((decimal)Array_Matrix.GetLength(1) / 2)) && (i <= Math.Ceiling((decimal)Array_Matrix.GetLength(0) / 2)))
                        Array_Matrix_Copy[i, j] = Array_Matrix[i, j - 1];
                    else if ((j > Math.Floor((decimal)Array_Matrix.GetLength(1) / 2)) && (i > Math.Ceiling((decimal)Array_Matrix.GetLength(0) / 2)))
                        Array_Matrix_Copy[i, j] = Array_Matrix[i - 1, j];

                    for (int x = 0; x < M; x++)
                    {
                        for (int y = 0; y < N; y++)
                        {
                            Console.Write("{0}\t", Array_Matrix_Copy[x, y]);
                        }
                        Console.WriteLine();
                    }
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    {
                    Console.Write("{0}\t", Array_Matrix_Copy[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            string[] Matrix = { "123456", "234567", "345678", "456789" };
            int M = 4;
            int N = 6;
            int T = 3;
            Level1.MatrixTurn(Matrix, M, N, T);

            Console.WriteLine("результат:");
            for (int i = 0; i < Matrix.Length; i++)
            {
                Console.WriteLine(" " + Matrix[i]);
            }
            Console.ReadKey();
        }
    }
}
#endregion