using System;
using System.Collections.Generic;

/// <summary>
/// Белые Ходоки
/// </summary>
///
/*
 Белые Ходоки снова готовят свою армию мертвецов для очередного штурма Стены. Но они подкрадываются к ней хитростью, стараясь незаметно затесаться среди мирных жителей окрестных деревень.
Для этого Ходоки принимают обличье крестьян, однако становятся различимыми, когда группируются в тройки -- температура вокруг них при этом понижается на 10 градусов.
Вы возглавляете Железный Трон Семи Королевств и посылаете разведчиков выявить всех врагов.

Дайте им подробные инструкции по определению вражеских сил в каждой деревне.
Каждая деревня задаётся ASCII-строкой (возможно, пустой).
В ней могут быть числа (жители, разбредшиется по полям), но только из одного символа (цифры от 0 до 9). То есть подряд несколько цифр не могут следовать.
Если в такой строке между каждой парой чисел (цифр), сумма которых равна 10, насчитываются ровно три Ходока (символ "="), значит, Ходоки успешно выявлены.

Функция

bool white_walkers(string village) 
получает параметром village строку, описывающую одну деревню, и возвращает true, если в ней выявляются все Ходоки.
Например:

"axxb6===4xaf5===eee5" => true
"5==ooooooo=5=5" => false
"abc=7==hdjs=3gg1=======5" => true
"aaS=8" => false
"9===1===9===1===9" => true

*/
#region 
///Золота: 2300$
//вилка цены: 4700 - 5300 руб.

namespace Level1Space
{
    public static class Level1
    {
        public static bool white_walkers(string village)
        {
            if (String.IsNullOrEmpty(village) || village.Length < 5)
                return false;
            else
            {
                bool walkersAvailable = false;
                List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                int firstNumber = 0;
                int firstIndex = 0;

                for (int i = 0; i < village.Length - 1; i++)
                {
                    if (numbers.Contains((int)char.GetNumericValue(village[i])))
                    {
                        if (firstNumber == 0)
                        {
                            firstNumber = Convert.ToInt16(char.GetNumericValue(village[i]));
                            firstIndex = i;
                        }
                        int j;
                        int countNumbersOfEqual = 0;
                        for (j = i + 1; j < village.Length; j++)
                        {
                            if (village[j] == '=')
                                countNumbersOfEqual++;
                            if (numbers.Contains((int)char.GetNumericValue(village[j])))
                            {
                                if (firstNumber + (int)char.GetNumericValue(village[j]) == 10)
                                {
                                    if (countNumbersOfEqual == 3)
                                        walkersAvailable = true;
                                    else
                                        walkersAvailable = false;
                                }
                                break;
                            }
                        }

                        i += (j - firstIndex - 1);
                        firstNumber = 0;
                    }
                }
                if (walkersAvailable == true)
                    return true;
                else
                    return false;
            }
        }
        
        static void Main()
        {
            string village = "axxb6===4xaf5===eee5";

            Console.WriteLine("результат: " + Level1.white_walkers(village));
            Console.ReadKey();
        }
    }
}
#endregion
