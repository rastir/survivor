using System;
using System.Collections.Generic;

/// <summary>
/// Гарри Поттер идёт в первый класс Хогвартса
/// </summary>
///

// Казалось бы, чего тут сложного -- выучил несколько колдовских слов, произнёс, и... никакого эффекта. Именно поэтому в специальных учебных заведениях наподобие Хогвартса вербальную магию изучают годами. Дело в том, что в волшебных учебниках написаны слова заклинания, которые сами по себе не работают. Их надо уметь преобразовывать в действующую магию с помощью специальных алгоритмов. Давайте познакомимся с одним из них.
//У нас имеется не-магическое слово -- стандартная последовательность русских и английских букв (строковый тип). Такие слова в любом языке программирования можно сравнивать, используя обычный лексикографический порядок, когда "а" меньше чем "я", "a" меньше чем "z" и т. д.
//Задача: преобразовать такое слово в магическое с помощью любого числа перестановок двух любых букв в слове, либо убедиться, что получить магическое слово невозможно.
//Итоговое слово должно отвечать двум требованиям:
//1) оно лексикографически больше, чем исходное слово;
//2) оно наименьшее из всех лексикографически больших слов, которые можно получить перестановкой пары букв.

//Тестовые примеры:
//"ая" преобразовываем в "яа"
//"fff" - невозможно преобразовать
//"нклм" в "нкмл"
//"вибк" в "викб"
//"вкиб" в "ибвк"

//Функция
//string BiggerGreater(string input)

//получает на вход исходную строку длиной 2 или более русских или английских строковых (маленьких) букв, и возвращает итоговое магическое слово. Если получить его невозможно, возвращается пустая строка.
//Например, BiggerGreater("вибк") = "викб"; BiggerGreater("fff") = "".
#region

#endregion

#region c печатью попытка 1 - 05.11.2021
///Золота: 1217$
///вилка цены: 4400 - 5700 руб.
namespace Level1Space
{
    public static class Level1
    {
        public static List<string> arr = new List<string>();

        public static string BiggerGreater(string input)
        {
            if (String.IsNullOrEmpty(input)) //строка непустая
                return "";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i].ToString() == " ")
                    return "";
                if ((i + 1) >= input.Length)
                    break;
                
                for (int a = 1; a < input.Length; a++)
                {
                    if (input[i].ToString() == " ")
                        return "";
                    if ((i + a) >= input.Length)
                        break;

                    char[] word = input.ToCharArray();
                    char temp = word[i];

                    word[i] = word[i + a];
                    word[i + a] = temp;

                    string str1 = input.Substring(0, i + a);
                    string str2 = "";

                    //int y = a + 1;
                    for (int c = 0; c < str1.Length; c++)
                    {
                        str2 += word[c];
                    }

                    if (str1.CompareTo(str2) == -1)
                    {
                        string worrd = "";
                        for (int j = 0; j < word.Length; j++)
                        {
                            worrd += word[j];
                        }

                        if (!arr.Contains(worrd))
                            arr.Add(worrd);

                        int b;
                        string word_copy = worrd;
                        char[] array;// = word_copy.ToCharArray();
                        char[] array2 = word_copy.ToCharArray();

                        for (b = i + 1; b < word_copy.Length; b++)
                        {
                            if (word_copy[b].ToString() == " ")
                                return "";

                            for (int f = b; f < word_copy.Length; f++)
                            {
                                if (word_copy[f].ToString() == " ")
                                    return "";
                                if ((f + 1) >= word_copy.Length)
                                    break;
                                
                                array = word_copy.ToCharArray();

                                char temp2 = array[b];
                                array[b] = array[f + 1];
                                array[f + 1] = temp2;

                                worrd = "";
                                for (int x = 0; x < array.Length; x++)
                                {
                                    worrd += array[x];
                                }
                                if (!arr.Contains(worrd))
                                    arr.Add(worrd.ToString());
                            }
                        }
                    }
                }
            }
            if (arr.Count > 0)
            {
                arr.Sort();
                return arr[0];
            }
            else
                return "";
        }
    #endregion

    static void Main()
        {
            //Console.WriteLine(Level1.BiggerGreater("ая"));
            //Console.WriteLine();

            //Console.WriteLine(Level1.BiggerGreater("fff"));
            //Console.WriteLine();

            //Console.WriteLine(Level1.BiggerGreater("нклм"));
            //Console.WriteLine();

            //Console.WriteLine(Level1.BiggerGreater("вибк"));
            //Console.WriteLine();

            Console.WriteLine(Level1.BiggerGreater("вкиб"));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}