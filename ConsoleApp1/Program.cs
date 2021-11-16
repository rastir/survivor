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

            decimal number = 1;
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

            while (number <= T)
            {
                int a = 0, b = 0, ind1 = M, ind2 = N;

                while (a <= Math.Floor((decimal)M / 2) - 1 && b <= Math.Floor((decimal)N / 2) - 1)
                {
                    ind1--;
                    ind2--;
                    //1 строка кольца
                    for (int y = b + 1; y < N; y++)
                    {
                        if (number % 2 != 0)
                            Array_Matrix_Copy[a, y] = Array_Matrix[a, y - 1];
                        else
                            Array_Matrix[a, y] = Array_Matrix_Copy[a, y - 1];
                    }
                    //Console.WriteLine();
                    //for (int x = 0; x < M; x++)
                    //{
                    //    for (int y = 0; y < N; y++)
                    //    {
                    //        Console.Write("{0}\t", Array_Matrix_Copy[x, y]);
                    //    }
                    //    Console.WriteLine();
                    //}
                    //посл столбец кольца
                    int temp1 = a;
                    for (int x = a + 1; x <= ind1; x++)
                    {
                        if (number % 2 != 0)
                        {
                            Array_Matrix_Copy[x, ind2] = Array_Matrix[temp1, ind2];
                            if (temp1 < ind1 - 1)
                                temp1++;
                        }
                        else
                        {
                            Array_Matrix[x, ind2] = Array_Matrix_Copy[temp1, ind2];
                            if (temp1 < ind1 - 1)
                                temp1++;
                        }
                    }


                    //if (number % 2 != 0)
                    //{
                    //    Console.WriteLine();
                    //    for (int x = 0; x < M; x++)
                    //    {
                    //        for (int y = 0; y < N; y++)
                    //        {
                    //            Console.Write("{0}\t", Array_Matrix_Copy[x, y]);
                    //        }
                    //        Console.WriteLine();
                    //    }
                    //}
                    //else
                    //{
                    //    Console.WriteLine();
                    //    for (int x = 0; x < M; x++)
                    //    {
                    //        for (int y = 0; y < N; y++)
                    //        {
                    //            Console.Write("{0}\t", Array_Matrix[x, y]);
                    //        }
                    //        Console.WriteLine();
                    //    }
                    //}




                    //посл строка кольца
                    int temp2 = ind2;
                    for (int y = ind2 - 1; y >= 0; y--)
                    {
                        if (number % 2 != 0)
                        {
                            Array_Matrix_Copy[ind1, y] = Array_Matrix[ind1, temp2];
                            if (temp2 > 0)
                                temp2--;
                        }
                        else
                        {
                            Array_Matrix[ind1, y] = Array_Matrix_Copy[ind1, temp2];
                            if (temp2 > 0)
                                temp2--;
                        }
                    }
                    //Console.WriteLine();
                    //for (int x = 0; x < M; x++)
                    //{
                    //    for (int y = 0; y < N; y++)
                    //    {
                    //        Console.Write("{0}\t", Array_Matrix_Copy[x, y]);
                    //    }
                    //    Console.WriteLine();
                    //}
                    //1 столбец кольца
                    int temp3 = M - 1;
                    for (int x = M - 2; x >= a; x--)
                    {
                        if (number % 2 != 0)
                        {
                            Array_Matrix_Copy[x, a] = Array_Matrix[temp3, a];
                            if (temp3 > 0)
                                temp3--;
                        }
                        else
                        {
                            Array_Matrix[x, a] = Array_Matrix_Copy[temp3, a];
                            if (temp3 > 0)
                                temp3--;
                        }
                    }
                    //Console.WriteLine();
                    //for (int x = 0; x < M; x++)
                    //{
                    //    for (int y = 0; y < N; y++)
                    //    {
                    //        Console.Write("{0}\t", Array_Matrix_Copy[x, y]);
                    //    }
                    //    Console.WriteLine();
                    //}


                    a++; b++;
                }

                if (number % 2 != 0)
                {
                    Console.WriteLine();
                    for (int x = 0; x < M; x++)
                    {
                        for (int y = 0; y < N; y++)
                        {
                            Console.Write("{0}\t", Array_Matrix_Copy[x, y]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    for (int x = 0; x < M; x++)
                    {
                        for (int y = 0; y < N; y++)
                        {
                            Console.Write("{0}\t", Array_Matrix[x, y]);
                        }
                        Console.WriteLine();
                    }
                }
                number++;
            }

            Array.Clear(Matrix,0,Matrix.Length);
            for (int x = 0; x < M; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    if (T % 2 != 0)
                        Matrix[x] += Array_Matrix_Copy[x, y];
                    else
                        Matrix[x] += Array_Matrix[x, y];
                }
            }

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(" ", Matrix[i]);
            }
        }
        static void Main()
        {
            string[] Matrix = { "123456", "234567", "345678", "456789" };
            int M = 4;
            int N = 6;
            int T = 9;
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