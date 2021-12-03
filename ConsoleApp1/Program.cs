using System;
using System.Collections.Generic;

/// <summary>
/// Тренируем сборную России по футболу
/// </summary>
///
/*
На входе -- массив произвольных целых чисел (значения не повторяются).

Ваша задача -- попробовать упорядочить его по возрастанию с помощью однократного применения одного из двух приёмов:
1. Поменять местами два произвольных элемента массива.
2. Изменить на обратный порядок произвольной последовательной цепочки элементов в массиве.
Например, на входе

1) 1 3 2
Упорядочиваем правилом 1, меняем местами 3 и 2:
1 2 3

2) 3 2 1
Упорядочиваем правилом 2, меняем порядок с первого элемента до последнего:
1 2 3

3) 1 7 5 3 9
Упорядочиваем правилом 1, меняем местами 7 и 3:
1 3 5 7 9

4) 9 5 3 7 1
Нельзя упорядочить.

5) 1 4 3 2 5
Упорядочиваем правилом 2, меняем порядок с второго элемента до четвёртого:
1 2 3 4 5
Функция
boolean Football(int F[], int N)
получает на вход массив F из N (N >= 1) целых неповторяющихся чисел и возвращает true, если массив можно упорядочить однократным применением одного из двух правил.
*/
#region 
///Золота: 2300$
//вилка цены: 4700 - 5300 руб.

namespace Level1Space
{
    public static class Level1
    {
        public static bool Football(int[] F, int N)
        {
            ///1. поменять местами два произвольных элемента: если предыдущий элемент больше следующего и таких ситуаций более одного - то нет
            ///2. изменить на обратный порядок произвольной последовательности: определить начало  и конец последовательности
            ///
            int startindex = 0;
            int endindex = 0;
            bool true_startindex = false;

            bool notOrder = false;
            int[] F_copy = new int[N];
            Array.Copy(F, 0, F_copy, 0, N);
            int temp;

            for (int i = 1; i < F.Length; i++)
            {
                if (F[i - 1] > F[i])
                {
                    if (startindex == 0 && true_startindex == false)
                    {
                        startindex = i - 1;
                        true_startindex = true;
                    }
                }
                if (i > 1 && F[i] > F[i - 1] && F[i - 2] > F[i - 1])
                {
                    if (endindex == 0)
                        endindex = i - 1;
                }
            }
            if (endindex == 0)
                endindex = startindex + (N - (startindex + 1));
            temp = F_copy[startindex];
            F_copy[startindex] = F_copy[endindex];
            F_copy[endindex] = temp;

            //проверка
            for (int i = 1; i < F_copy.Length; i++)
            {
                if (F_copy[i] < F_copy[i - 1])
                    notOrder = true;
            }
            if (notOrder == false)
                return true;
            else
            {
                Array.Reverse(F, startindex,  endindex - startindex + 1);


                for (int i = 1; i < F.Length; i++)
                {
                    if (F[i] < F[i - 1])
                        notOrder = true;
                }
                if (notOrder == false)
                    return true;
                else 
                    return false;
            }
        }
        
        static void Main()
        {
            int[] F = { 9, 5, 3, 7, 1};
            int N = 5;

            Console.WriteLine("результат: " + Level1.Football(F, N));
            Console.ReadKey();
        }
    }
}
#endregion
