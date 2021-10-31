using System;
using System.Collections.Generic;

/// <summary>
/// Автоматизация отчётности о продажах
/// </summary>
///  Интернет-магазин "Платья и Сумки" быстро расширяется, и его создатели 
///  заинтересованы в подробной аналитической отчётности о продажах товара. 
///  К сожалению, первая версия магазина была сделана очень криво, 
///  поэтому данные хранятся в системе в виде, плохо подходящем для обработки. 
///  Так, каждая запись о продаже представляет собой строку формата

//название - товара количество - проданных - штук

//например:

//платье1 5
//сумка32 2
//платье1 1
//сумка23 2
//сумка128 4

//Названия товаров могут повторяться.

//Ваша задача: сгруппировать продажи по названиям товаров, расположив в результирующем списке товары, отсортированные по количеству продаж. Если эти количества для каких-то товаров совпадут, названия товаров должны следовать в порядке лексикографического возрастания.

//Например, вышеприведённый пример преобразуется в такой результат:

//платье1 6
//сумка128 4
//сумка23 2
//сумка32 2

//Функция

//string[] ShopOLAP(int N, string[] items)

//получает на вход N >= 1 строк о товарах в вышеприведённом формате, и выдаёт массив длиной M <= N, содержащий сводку по продажам в сгруппированном виде. 
#region пробую с печатью
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static string[] ShopOLAP(int N, string[] items)
//        {
//            string[] subs1 = new string[items.Length - 1];
//            string[] subs2 = new string[items.Length - 1];

//            string[] array1 = new string[items.Length];
//            string[] array2 = new string[items.Length];
//            int sum, a ,b;
//            //группируем и складываем
//            for (int i = 0; i < items.Length - 1; i++)
//            {
//                // for (int j = 0; j < 2; j++)
//                //{
//                string str1 = items[i].ToString();
//                subs1 = str1.Split();
//                array1[i] = subs1[0];
//                array1[i + 1] = subs1[1];
//                sum = Convert.ToInt32(array1[i + 1]);

//                for (int x = 0; x < items.Length - 1; x++)
//                {
//                    if (i != x)
//                    {
//                        string str2 = items[x].ToString();
//                        subs2 = str2.Split();
//                        array2[x] = subs2[0];
//                        array2[x + 1] = subs2[1];
//                        ///Меньше нуля 	Первая подстрока предшествует второй подстроке в порядке сортировки.
//                        ///Нуль Подстроки появляются в той же позиции в порядке сортировки, или параметр length равен нулю.
//                        ///Больше нуля Первая подстрока соответствует второй подстроке в порядке сортировки.
//                        if (array1[i].CompareTo(array2[x]) == 0) //если одинаковые названия товара
//                        {
//                            sum += Convert.ToInt32(array2[x + 1]);
//                            items[i] = string.Join(" ", array1[i], sum);
//                            for (int j = x; j < items.Length - 1; j++) //перенумеровываем массив
//                            {
//                                items[j] = items[j + 1];
//                                Console.Write(items[j] + " ");
//                            }
//                            x--;

//                            Array.Resize(ref items, items.Length - 1);
//                            Console.WriteLine();
//                        }
//                        //Console.Write();
//                    }
//                }
//                Console.WriteLine();
//            }
//            Array.Sort(items);
//            for (int i = 0; i < items.Length; i++)
//            {
//                Console.Write(items[i]+" ");
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            return items;
//        }
#endregion
#region c печатью2
//namespace Level1Space
//{
//    public static class Level1
//    {
//        public static string[] ShopOLAP(int N, string[] items)
//        {
//            string[] subs1; //= new string[items.Length - 1];
//            string[] subs2; //= new string[items.Length - 1];

//            string[] array1 = new string[items.Length];
//            string[] array2 = new string[items.Length];
//            int sum;

//            for (int i = 0; i < items.Length - 1; i++)
//            {
//                string str1 = items[i].ToString();
//                subs1 = str1.Split();
//                array1[i] = subs1[0];
//                array1[i + 1] = subs1[1];
//                sum = Convert.ToInt32(array1[i + 1]);

//                for (int x = 0; x < items.Length; x++)
//                {
//                    if (i != x)
//                    {
//                        string str2 = items[x].ToString();
//                        subs2 = str2.Split();
//                        array2[x] = subs2[0];
//                        array2[x + 1] = subs2[1];

//                        if (array1[i].CompareTo(array2[x]) == 0)
//                        {
//                            sum += Convert.ToInt32(array2[x + 1]);
//                            items[i] = string.Join(" ", array1[i], sum);
//                            for (int j = x; j < items.Length - 1; j++)
//                            {
//                                items[j] = items[j + 1];
//                            }
//                            x--;
//                            Array.Resize(ref items, items.Length - 1);
//                            for (int y = 0; y < items.Length; y++)
//                            {
//                                Console.WriteLine(items[y]);
//                            }
//                            Console.WriteLine();
//                        }
//                    }
//                    Console.WriteLine();
//                }
//            }
//            Console.WriteLine();
//            for (int y = 0; y < items.Length; y++)
//            {
//                Console.WriteLine(items[y]);
//            }

//            string[] arr1 = new string[items.Length];
//            string[] sub1; //= new string[items.Length - 1];
//            string[] arr2 = new string[items.Length];
//            string[] sub2; //= new string[items.Length - 1];
//            bool sort = false;

//            while (sort == false)
//            {
//                sort = true;
//                for (int y = 0; y < items.Length - 1; y++)
//                {
//                    string str1 = items[y].ToString();
//                    string str2 = items[y + 1].ToString();

//                    sub1 = str1.Split();
//                    sub2 = str2.Split();

//                    string word1 = sub1[0];
//                    string word2 = sub2[0];

//                    arr1[y + 1] = sub1[1];
//                    arr2[y + 1] = sub2[1];

//                    if (Convert.ToInt32(arr1[y + 1]).CompareTo(Convert.ToInt32(arr2[y + 1])) == 0)
//                    {
//                        if (word1.CompareTo(word2) == 1)
//                        {
//                            string temp = items[y + 1];
//                            items[y + 1] = items[y];
//                            items[y] = temp;
//                            sort = false;
//                        }
//                        //items[y] = string.Join(" ", array1[y]);
//                        for (int j = y; j < items.Length - 1; j++)
//                        {
//                            items[j] = items[j + 1];
//                        }

//                    }
//                    else if (Convert.ToInt32(arr1[y + 1]).CompareTo(Convert.ToInt32(arr2[y + 1])) == -1)
//                    {
//                        string temp = items[y];
//                        items[y] = items[y + 1];
//                        items[y + 1] = temp;
//                        sort = false;
//                    }
//                    Console.WriteLine();
//                    Array.Sort(items);
//                    for (int r = 0; r < items.Length; r++)
//                    {
//                        Console.WriteLine(items[r]);
//                    }
//                }
//            }
//            Console.WriteLine();
//            Array.Sort(items);
//            for (int y = 0; y < items.Length; y++)
//            {
//                Console.WriteLine(items[y]);
//            }
//            return items;
//        }
#endregion

#region без печати3 попытка 1
///Золота: 1008$
//вилка цены: 4200 - 5900 руб.
namespace Level1Space
{
    public static class Level1
    {
        public static string[] ShopOLAP(int N, string[] items)
        {
            string[] subs1;
            string[] subs2;

            string[] array1 = new string[items.Length];
            string[] array2 = new string[items.Length];
            int sum;

            for (int i = 0; i < items.Length - 1; i++)
            {
                string str1 = items[i].ToString();
                subs1 = str1.Split();
                array1[i] = subs1[0];
                array1[i + 1] = subs1[1];
                sum = Convert.ToInt32(array1[i + 1]);

                for (int x = 0; x < items.Length; x++)
                {
                    if (i != x)
                    {
                        string str2 = items[x].ToString();
                        subs2 = str2.Split();
                        string array2x = subs2[0];
                        string array2x1 = subs2[1];

                        if (array1[i].CompareTo(array2x) == 0)
                        {
                            sum += Convert.ToInt32(array2x1);
                            items[i] = string.Join(" ", array1[i], sum);

                            for (int j = x; j < items.Length - 1; j++)
                            {
                                items[j] = items[j + 1];
                            }

                            x--;
                            Array.Resize(ref items, items.Length - 1);
                        }
                    }
                }
            }

            string[] arr1 = new string[items.Length];
            string[] sub1;
            string[] arr2 = new string[items.Length];
            string[] sub2;
            bool sort = false;

            while (sort == false)
            {
                sort = true;
                for (int y = 0; y < items.Length - 1; y++)
                {
                    string str1 = items[y].ToString();
                    string str2 = items[y + 1].ToString();

                    sub1 = str1.Split();
                    sub2 = str2.Split();

                    string word1 = sub1[0];
                    string word2 = sub2[0];

                    arr1[y + 1] = sub1[1];
                    arr2[y + 1] = sub2[1];

                    if (Convert.ToInt32(arr1[y + 1]).CompareTo(Convert.ToInt32(arr2[y + 1])) == 0)
                    {
                        if (word1.CompareTo(word2) == 1)
                        {
                            string temp = items[y + 1];
                            items[y + 1] = items[y];
                            items[y] = temp;
                            sort = false;
                        }
                    }
                    else if (Convert.ToInt32(arr1[y + 1]).CompareTo(Convert.ToInt32(arr2[y + 1])) == -1)
                    {
                        string temp = items[y];
                        items[y] = items[y + 1];
                        items[y + 1] = temp;
                        sort = false;
                    }
                }
            }
            return items;
        }
        #endregion

        static void Main()
        {
            int N = 8;
            string[] items = { "123 5", "32 3", "124 5", "128 1", "32 2", "23 4", "128 4", "128 1" };
            items = ShopOLAP(N, items);
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}