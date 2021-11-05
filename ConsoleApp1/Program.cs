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
                if (((i + 1) >= input.Length) || (input[i].ToString() == " "))
                    return "";
                
                char[] word = input.ToCharArray();
                char temp = word[i];

                word[i] = word[i + 1];  
                word[i + 1] = temp;

                string str1 = input.Substring(0, i + 2);
                string str2 = "";

                int y = i + 1;
                for (int c = 0; c <= y; c++) 
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
                    
                    arr.Add(worrd);
                    char[] word2 = word;

                    int b;
                    for (b = i + 1; b < worrd.Length; b++)
                    {
                        string word_copy = worrd;

                        if ((b + 1) >= word_copy.Length)
                            break;
                        char[] array = word_copy.ToCharArray();
                        char temp2 = array[b];
                        array[b] = array[b + 1];
                        array[b + 1] = temp2;

                        worrd = "";
                        for (int x = 0; x < array.Length; x++)
                        {
                            worrd += array[x];
                        }
                        arr.Add(worrd.ToString());
                    }
                }
            }
            arr.Sort();
            return arr[0];
        }
    #endregion

    static void Main()
        {
            Console.WriteLine(Level1.BiggerGreater("ая"));
            Console.WriteLine();

            Console.WriteLine(Level1.BiggerGreater("fff"));
            Console.WriteLine();

            Console.WriteLine(Level1.BiggerGreater("нклм"));
            Console.WriteLine();

            Console.WriteLine(Level1.BiggerGreater("вибк"));
            Console.WriteLine();

            Console.WriteLine(Level1.BiggerGreater("вкиб"));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}