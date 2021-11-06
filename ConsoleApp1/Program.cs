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

#region c печатью попытка 1 - 05.11.2021
///Золота: 1567$
//вилка цены: 4400 - 5600 руб.

namespace Level1Space
{
    public static class Level1
    {
        public static List<Passwords> pwd_list = new List<Passwords>();
        public class Passwords
        {
            public string key = "";
            public int value = 0;
        }
        public static bool SherlockValidString(string s)
        {
        
        Dictionary<string, int > pwd = new Dictionary<string, int>();

            for (int i = 0; i < s.Length; i++)
            {
                //if (rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4) { rrr.Clear(); rrr = new List<commands>(); } //rrr = new List<commands>(); }
                if (pwd_list.FindLast(t => t == t) != null && pwd_list.FindLast(t => t == t).key == s[i].ToString()) //(pwd.Keys.Equals(s[i]))
                {
                    //pwd_list.FindLastIndex(t => t == t). .key == s[i].ToString()
                    //Level1Space.Level1.Passwords[]
                    //pwd[s[i].ToString()]++;
                }
                else
                {
                    Passwords list1 = new Passwords();
                    list1.key = s[i].ToString();
                    list1.value = 1;
                    pwd_list.Add(list1);
                }

            }

            int firstElement = pwd[s[0].ToString()];
            int number_of_meet = 0;

            foreach (var recordOfDictionary in pwd)
            {
                if (firstElement != recordOfDictionary.Value)
                    number_of_meet++;
            }

            if (number_of_meet == 0)
                return true;
            else if (number_of_meet > 1)
                return false;
            else
            {
                bool result = false;
                foreach (var recordOfDictionary in pwd)
                {
                    if (firstElement != recordOfDictionary.Value)
                    {
                        if (Math.Abs(number_of_meet - recordOfDictionary.Value) > 1)
                            return false;
                        else
                            result = true;
                    }
                    else
                        result = true;
                }
                return result;
            }
        }
    #endregion

    static void Main()
        {
            Console.WriteLine(Level1.SherlockValidString("xxyyzabc"));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}