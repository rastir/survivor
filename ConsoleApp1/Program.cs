using System;
using System.Collections.Generic;

/// <summary>
/// Шерлок Холмс и механическая шкатулка
/// </summary>
///

/// Cама суть этой загадки и то возбужденное состояние, в котором пребывал клиент Холмса, придавали этому делу необычный характер. Да и, кроме предстоящего расследования, 
/// мастерство моего друга, его умение удивительно быстро овладевать ситуацией и на основании тщательных наблюдений и простой логики делать поразительные по своей точности 
/// выводы зачаровывали меня. Изучать систему его работы и приемы, с помощью которых он в два счета распутывал сложнейшие загадки, для меня было настоящим удовольствием.
///Шерлок Холмс в свободное время упражняется в проверке валидных паролей к его новой механической шкатулке. Пароли строятся из латинских букв и считаются валидными, если 
///в соответствующей строке пароля все буквы встречаются одинаковое количество раз. Кроме того, разрешается удалить одну любую букву, чтобы выполнилось условие равенства частоты всех букв.
///Например, строка xyz будет валидна, и строка xyzaa будет валидна (можно удалить одну a), и строка xxyyz будет валидна (можно удалить z). А строка xyzzz, или строка xxyyza или строка xxyyzabc невалидны.
///Напишите функцию, проверяющую строку на валидность.

///Функция
///boolean SherlockValidString(string s)
///получает на вход исходную строку длиной 2 или более английских букв, и возвращает true, если строка валидна. 

#region 
///Золота: 1567$ +
//вилка цены: 4400 - 5600 руб.

namespace Level1Space
{
    public static class Level1
    {
        public static bool SherlockValidString(string s)
        {
            if (String.IsNullOrEmpty(s))
                return false;

            Dictionary<char, int > pwd = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (pwd.TryGetValue(s[i], out _))
                    pwd[s[i]]++;
                else
                {
                    pwd.Add(s[i], 1);
                }
            }

            int firstElement = pwd[s[0]];
            int number_of_meet = 0;
            int Element1 = 0;
            int Element2 = 0;
            int Element3 = 0;

            string[,] Array = new string[2, pwd.Count];

            int p = 0;
            foreach (KeyValuePair<char, int> item in pwd)
            {
                Array[0, p] = item.Key.ToString();
                Array[1, p] = item.Value.ToString();
                p++;
            }

            int required_number = 0;
            if (pwd.Count >= 3)
            {
                for (int j = 0; j < Array.GetUpperBound(1) + 1; j++)
                {
                    if (j + 1 < Array.GetUpperBound(1) + 1)
                    {
                        if (Array[1, j] != Array[1, j + 1])
                        {
                            Element1 = Convert.ToInt32(Array[1, j]);
                            Element2 = Convert.ToInt32(Array[1, j + 1]);
                            if (j - 1 >= 0)
                                Element3 = Convert.ToInt32(Array[1, j - 1]);
                            if (j + 2 < Array.GetUpperBound(1) + 1)
                                Element3 = Convert.ToInt32(Array[1, j + 2]);

                            if (Element1 == Element2)
                                required_number = Element3;
                            else if (Element1 == Element3)
                                required_number = Element2;
                            else if (Element2 == Element3)
                                required_number = Element1;
                            break;
                        }
                    }
                }
            }
            foreach (var recordOfDictionary in pwd)
            {
                firstElement = recordOfDictionary.Value;

                foreach (var recordOfDictionary2 in pwd)
                {
                    if (recordOfDictionary.Key != recordOfDictionary2.Key)
                    {
                        if (firstElement != recordOfDictionary2.Value)
                        {
                            number_of_meet++;
                        }
                    }
                }
            }

            if (number_of_meet == 0)
                return true;
            else if (number_of_meet == ((pwd.Count - 1) * 2) || number_of_meet == pwd.Count)
            {
                bool result = false;
                firstElement = pwd[s[0]];

                if (pwd.Count >= 3)
                {
                    foreach (var recordOfDictionary in pwd)
                    {
                        if (firstElement != recordOfDictionary.Value)
                        {
                            if (recordOfDictionary.Value == required_number)
                            {
                                if (recordOfDictionary.Value == 1)
                                {
                                    result = true;
                                    break;
                                }
                                else if (firstElement < recordOfDictionary.Value)
                                {
                                    if (Math.Abs(firstElement - recordOfDictionary.Value) > 1)
                                    {
                                        result = false;
                                        break;
                                    }
                                    else
                                    {
                                        result = true;
                                        break;
                                    }
                                }
                                else if (firstElement > recordOfDictionary.Value)
                                {
                                    result = false;
                                    break;
                                }
                            }
                            if (firstElement == required_number)
                            {
                                if (firstElement == 1)
                                {
                                    result = true;
                                    break;
                                }
                                else if (firstElement > recordOfDictionary.Value)
                                {
                                    if (Math.Abs(firstElement - recordOfDictionary.Value) > 1)
                                    {
                                        result = false;
                                        break;
                                    }
                                    else
                                    {
                                        result = true;
                                        break;
                                    }
                                }
                                else if (firstElement < recordOfDictionary.Value)
                                {
                                    result = false;
                                    break;
                                }
                            }
                            firstElement = recordOfDictionary.Value;
                        }
                    }
                }
                else
                {
                    result = false;
                    foreach (var recordOfDictionary3 in pwd)
                    {
                        if (firstElement != recordOfDictionary3.Value)
                        {
                            if (Math.Abs(firstElement - recordOfDictionary3.Value) > 1)
                                return false;
                            else
                                result = true;
                        }
                        else
                            result = true;
                    }
                }
                return result;
            }
            else
                return false;
        }
    #endregion

    static void Main()
        {
            Console.WriteLine(Level1.SherlockValidString("xxxxxyyyyyyaaaaaa"));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}