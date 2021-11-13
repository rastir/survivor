using System;
using System.Collections.Generic;

/// <summary>
/// Древо Жизни Андрассил
/// </summary>
///

///  Только в Изумрудном Сне существует Древо Жизни Андрассил. Племена фурболгов, живущие в гигантском пне Нордскола, из поколения в поколение передают легенду об этом дереве, которое когда-нибудь вернётся в реальность и очистит мирные земли от порчи Древних Богов.
///Главный шаман фурболгов хранит манускрипт, описывающий схему развития Андрассила. Смоделируйте её на компьютере, чтобы всегда можно было узнать, на каком году в каком состоянии оно будет находиться.
///Дерево описывается массивом размером HxW. Каждый элемент массива принимает значение либо 0 (пусто), либо 1(ветка дерева).При этом у каждого элемента-ветки имеется дополнительная характеристика, равная сроку её жизни в годах.
///Исходные данные: размер массива, количество лет для моделирования, и начальная структура дерева в виде текстового изображения (списка текстовых строк).
/*
Например, размер 3x4, моделируем 12 лет, каждый пустой элемент задаётся символом ".", каждая ветка -- символом "+" (её возраст считается равным 1 году):

3 4 12

.+ ....+.
.+ ..Каждый год дерево перерождается по следующему алгоритму:
-в "первый"(чётный) год все ветки стареют на один год, и все пустые клетки заполняются новыми корнями с возрастом 1 год (визуально всё заполнено символами "+");
-во "второй"(нечётный) год все ветки стареют на один год; ветки, возраст которых три или более лет, погибают, уничтожая также четыре окружающие ветки (если они существуют) --по горизонтали и вертикали.

Процесс гибели веток с соседями происходит одновременно, т.е. надо учитывать, что каждая ветка с возрастом 3+ лет обязательно уничтожает окружающие ветки (нельзя удалять ветки-соседи простым перебором, потому что соседи тоже в свою очередь могут удалять своих соседей).
В примере для наглядности заменим ветки на числа с возрастом веток.
Исходное дерево:

.1....1.
.1..Прошёл 1 - й "чётный" год:

1211
1121
1211

2 - й "нечётный" год:

2322
2232
2322

Уничтожение:

...2
2...
...2

3 - й "чётный" год(по чётным годам старые ветки не уничтожаются):

1113
3111
1113

4 - й "нечётный" год:

2224
4222
2224

Уничтожение:

.2....2.
.2..и т.д.

    Напишите программу, которая моделирует N лет развития дерева, и выводит его результирующую форму -- список/массив строк (используются только символы "." и "+").

Функция

string[] TreeOfLife(int H, int W, int N, string[] tree)

получает высоту H (количество строк) и ширину W (длина строк) дерева, количество лет моделирования N и сам список строк, задающий начальное дерево с помощью "." и "+".

Например, исходный пример:

TreeOfLife(3, 4, 12, [".+..", "..+.", ".+.."])
*/
#region 
///Золота: 1567$ +
//вилка цены: 4400 - 5600 руб.

namespace Level1Space
{
    public static class Level1
    {
        #region
        //public static string[] TreeOfLife(int H, int W, int N, string[] tree)
        //{
        //    int[,] Array_tree = new int[H, W];
        //    int number = 1;
        //    for (int i = 0; i < H; i++) //переводим в двумерный массив
        //    {
        //        string word = tree[i];
        //        word.ToCharArray();

        //        for (int j = 0; j < W; j++)
        //        {
        //            if (word[j].ToString() == ".")
        //                Array_tree[i, j] = 0;
        //            if (word[j].ToString() == "+")
        //                Array_tree[i, j] = 1;
        //        }
        //    }

        //    for (int i = 0; i < H; i++)
        //    {
        //        for (int j = 0; j < W; j++)
        //        {
        //            Console.Write(Array_tree[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    while (number <= N)
        //    {
        //        number++;

        //        for (int i = 0; i < H; i++)
        //        {
        //            for (int j = 0; j < W; j++)
        //            {
        //                Array_tree[i, j]++;
        //            }
        //        }

        //        Console.WriteLine();
        //        for (int x = 0; x < H; x++)
        //        {
        //            for (int y = 0; y < W; y++)
        //            {
        //                Console.Write(Array_tree[x, y] + " ");
        //            }
        //            Console.WriteLine();
        //        }

        //        if (number % 2 != 0) //нечетный год уничтожение
        //        {
        //            for (int i = 0; i < H; i++)
        //            {
        //                for (int j = 0; j < W; j++)
        //                {
        //                    if (Array_tree[i, j] >= 3)
        //                    {
        //                        Array_tree[i, j] = 0;
        //                        if (i > 0 && Array_tree[i - 1, j] < 3)
        //                            Array_tree[i - 1, j] = 0; ;
        //                        if (i < H - 1 && Array_tree[i + 1, j] < 3)
        //                            Array_tree[i + 1, j] = 0;
        //                        if (j > 0 && Array_tree[i, j - 1] < 3)
        //                            Array_tree[i, j - 1] = 0;
        //                        if (j < W - 1 && Array_tree[i, j + 1] < 3)
        //                            Array_tree[i, j + 1] = 0;
        //                    }
        //                }
        //            }

        //            Console.WriteLine();
        //            for (int i = 0; i < H; i++)
        //            {
        //                for (int j = 0; j < W; j++)
        //                {
        //                    Console.Write(Array_tree[i, j] + " ");
        //                }
        //                Console.WriteLine();
        //            }
        //        }
        //    }

        //    Console.WriteLine();
        //    for (int i = 0; i < H; i++) 
        //    {
        //        for (int j = 0; j < W; j++)
        //        {
        //            Console.Write(Array_tree[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    string[] tree_result = new string[H];

        //    for (int i = 0; i < H; i++) //переводим в одномерный массив строк
        //    {
        //        for (int j = 0; j < W; j++)
        //        {
        //            if (Array_tree[i, j] == 0)
        //                tree_result[i] += ".";
        //            if (Array_tree[i, j] > 0)
        //                tree_result[i] += "+";
        //        }
        //    }

        //    Console.WriteLine();
        //    for (int i = 0; i < H; i++) //печатаем
        //    {
        //        Console.WriteLine(tree_result[i] + " ");
        //    }

        //    return tree_result;
        //}
        #endregion

        public static string[] TreeOfLife(int H, int W, int N, string[] tree)
        {
            int[,] Array_tree = new int[H, W];
            int number = 1;
            for (int i = 0; i < H; i++) 
            {
                string word = tree[i];
                word.ToCharArray();

                for (int j = 0; j < W; j++)
                {
                    if (word[j].ToString() == ".")
                        Array_tree[i, j] = 0;
                    if (word[j].ToString() == "+")
                        Array_tree[i, j] = 1;
                }
            }

            while (number <= N)
            {
                number++;

                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        Array_tree[i, j]++;
                    }
                }

                if (number % 2 != 0)
                {
                    for (int i = 0; i < H; i++)
                    {
                        for (int j = 0; j < W; j++)
                        {
                            if (Array_tree[i, j] >= 3)
                            {
                                Array_tree[i, j] = 0;
                                if (i > 0 && Array_tree[i - 1, j] < 3)
                                    Array_tree[i - 1, j] = 0; ;
                                if (i < H - 1 && Array_tree[i + 1, j] < 3)
                                    Array_tree[i + 1, j] = 0;
                                if (j > 0 && Array_tree[i, j - 1] < 3)
                                    Array_tree[i, j - 1] = 0;
                                if (j < W - 1 && Array_tree[i, j + 1] < 3)
                                    Array_tree[i, j + 1] = 0;
                            }
                        }
                    }
                }
            }

            string[] tree_result = new string[H];

            for (int i = 0; i < H; i++) 
            {
                for (int j = 0; j < W; j++)
                {
                    if (Array_tree[i, j] == 0)
                        tree_result[i] += ".";
                    if (Array_tree[i, j] > 0)
                        tree_result[i] += "+";
                }
            }

            return tree_result;
        }

        static void Main()
        {
            //string[] array = { ".+..", "..+.", ".+.." };
            //int H = 3;
            //int W = 4;
            //int N = 12;
            //array = Level1.TreeOfLife(H,W,N,array);

            //Console.WriteLine("результат:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(" " + array[i]);
            //}
            //Console.ReadKey();
        }
    }
}
#endregion