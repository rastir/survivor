using System;
using System.Collections.Generic;

/// <summary>
/// Чубакка и гравитационные колодцы
/// </summary>
///
/*
 На входе одномерный массив A (индексация начинается с нуля) случайных положительных целых чисел (возможно, повторяющихся).

Трансформирующая трансформация S массива A происходит так:

0. Выходной массив/список B исходно пуст.

1. Организуем первый цикл для i, начиная с 0 и до длины массива A минус 1.

2. Организуем внутри первого цикла второй цикл для j, начиная с 0 и до длины массива A минус i минус 1.

3. Рассчитываем значение k = i + j.

4. Из поддиапазона A[ j..k ] выбираем максимальное значение и записываем в конец списка B.

По завершении всех циклов список B считаем трансформирующей трансформацией, которую назовём S(A).
Говоря программистским языком, есть функция S(A), которая возвращает список B.

5. Ключевой ключ находится суммированием всех элементов списка, получаемого двойной трансформацией S(S(A)) (результат первой трансформации подаётся на вход второй трансформации).

Реализуйте алгоритм поиска ключевого ключа и выводите true, если он чётный.

Функция

boolean TransformTransform(int A[], int N)

получает на вход массив из N (N >= 1) целых положительных чисел и возвращает true, если сумма всех значений результата двойной трансформации A чётная. 

*/
#region 
///Золота: 2662$ +
//вилка цены: 4500 - 5300 руб.

namespace Level1Space
{
    public static class Level1
    {
        public static bool TransformTransform(int[] A, int N)
        {
            List<int> B = new List<int>();
            int k;
            int maxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {

                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    k = i + j;
                    maxValue = 0;

                    for (int x = j; x <= k; x++)
                    {
                        if (A[x] > maxValue)
                        {
                            // найден больший элемент
                            maxValue  = A[x];
                        }
                    }
                        B.Add(maxValue);
                }
            }

            List<int> C = new List<int>();

            for (int i = 0; i < B.Count - 1; i++)
            {
                for (int j = 0; j < B.Count - i - 1; j++)
                {
                    k = i + j;
                    maxValue = 0;
                    for (int x = j; x <= k; x++)
                    {
                        if (B[x] > maxValue)
                        {
                            // найден больший элемент
                            maxValue = B[x];
                        }
                    }
                    //if (maxValue > 0)
                        C.Add(maxValue);
                }
            }

            int summ = 0;
            for (int x = 0; x < C.Count; x++)
            {
                summ += C[x];
            }

            if (summ % 2 == 0)
                return true;
            else
                return false;
        }
        
        public static int summ;

        static void Main()
        {

        }
    }
}
#endregion
