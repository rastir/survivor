using System;
using System.Collections.Generic;

/// <summary>
/// Делаем национальный редактор "Лапоть"
/// </summary>
///   В рамках проекта тотального импортозамещения решено полностью с нуля переписать весь офисный софт в стране. Вы получили подряд с бюджетом миллион рублей по созданию оригинального текстового редактора "Лапоть". Закодируйте его максимально компактно!
#region
//"Лапоть" поддерживает пять операций:

//1.Добавить(S)-- в конец текущей строки (исходно пустая) добавляется строка S;
//2.Удалить(N)-- удалить N символов из конца текущей строки. Если N больше длины текущей строки, удаляем из неё все символы;
//3.Выдать(i)-- выдать i-й символ текущей строки (индексация начинается с нуля) в формате строки (строковый тип). Если индекс за пределами строки, возвращайте пустую строку;
//4.Undo()-- отмена последней операции 1 или 2; отмена должна уметь выполняться при необходимости неограниченное число раз;
//5.Redo()-- выполнить заново последнюю отменённую с помощью Undo операцию; Redo должна уметь выполняться при необходимости неограниченное число раз.
//Если после Undo выполняется операция 1 или 2, то
//-- предыдущая цепочка операций для Undo обнуляется (откатить можно только последнюю операцию 1 или 2);
//--Redo более становится нечего откатывать.
//На вход редактора подаётся одна строка, первый символ которой -- номер операции (1-5) и через пробел, при необходимости, параметр соответствующей операции.
//Например:
//1 Привет
//В текущей строке будет "Привет"
//1  , Мир!
//Привет, Мир!
//1 ++ 
//Привет, Мир!++
//2 2
//Привет, Мир!
//4
//Привет, Мир!++
//4
//Привет, Мир!
//1 *
//Привет, Мир!*
//4
//Привет, Мир!
//4 
//Привет, Мир!
//4
//Привет, Мир!
//3 6
//,
//2 100

//1 Привет 
//Привет
//1  , Мир!
//Привет, Мир!
//1 ++ 
//Привет, Мир!++
//4
//Привет, Мир!
//4
//Привет
//5
//Привет, Мир!
//4
//Привет
//5
//Привет, Мир!
//5
//Привет, Мир!++
//5
//Привет, Мир!++
//5
//Привет, Мир!++
//4
//Привет, Мир!
//4
//Привет
//2 2
//Прив
//4
//Привет
//5
//Прив
//5
//Прив
//5
//Прив

//Функция

//string BastShoe(string command)          

//получает на вход строку в формате "N параметр", где N -- код операции (1-5),
//- и возвращает текущую строку,
//- или символ в формате строки, если команда Выдать(),
//- или пустую строку в случае её ошибки.
//Например, BastShoe("1 Привет") = "Привет"

//Если команда задана некорректно, Лапоть ничего не делает (просто возвращает текущую строку без изменений). 
#endregion

#region c печатью попытка 1 - 31.10.2021
///Золота: 1182$
///вилка цены: 4300 - 5800 руб.
namespace Level1Space
{
    public static class Level1
    {
        public static string S = "";//текущая строка
        public static string lastcommand = "";//текущая команда
        public static int C = 0; //храним все действия Operation
        public static int D = 0;//храним все действия Undo 
        public static string[] Operation = new string[100000];
        public static string[] Undo = new string[100000];

        public static string BastShoe(string command)
        {
            char[] massiv = command.ToCharArray();
            int burr = Convert.ToInt32(command.Substring(0, 1));

            //for (int i = 0; i < Operation.Length; i++)
            //{
            //    Console.WriteLine(Operation[i]);
            //}

            switch (burr)
            {
                case 1:
                    //проверяем предыдущую операцию        
                    if (lastcommand != "")
                    {
                        if (lastcommand[0].ToString() == "4") //если последняя операция была Undo то чистим память операций для Undo
                        {
                            //Array.Clear(Undo, 0, Undo.Length - 1);
                            Array.Clear(Operation, 0, Operation.Length - 1);
                            C = 0;
                        }
                    }
                    C++;
                    Operation[C] = command; //запоминаем текущую операцию
                    lastcommand = "";

                    for (int i = 0; i < command.Length; i++)
                    {
                        if (i > 1)
                            S += massiv[i];
                    }
                    return S;

                case 2:
                    //проверяем предыдущую операцию        
                    if (lastcommand != "")
                    {
                        if (lastcommand[0].ToString() == "4") //если последняя операция была Undo то чистим память операций для Undo
                        {
                            //Array.Clear(Undo, 0, Undo.Length - 1);
                            Array.Clear(Operation, 0, Operation.Length - 1);
                            C = 0;
                        }
                    }
                    C++;
                    lastcommand = "";
                    Operation[C] = command; //запоминаем текущую операцию

                    string[] words2;
                        words2 = command.Split(" ");
                    int second2 = Convert.ToInt32(words2[1]);
                    if (second2 > S.Length)
                        second2 = S.Length;
                    if ((S.Length - second2) > 0)
                            S = S.Remove(S.Length - second2);
                    return S;

                case 3:
                    lastcommand = "";
                    string[] words3 = command.Split(" ");
                    int second3 = Convert.ToInt32(words3[1]);
                    if (second3 > S.Length)
                        return "";
                    else
                        return S[second3].ToString();

                case 4:
                    if (C > 0)
                    {
                        string otmena4 = Operation[C];
                        int count_stroka2 = 0;
                        lastcommand = command;

                        if (otmena4[0].ToString() == "1") //если последняяя операция была добавить то удаляем
                        {
                            string stroka4 = "2 ";

                            for (int i = 0; i < Operation[C].Length; i++)
                            {
                                if (i > 1)
                                {
                                    count_stroka2++;
                                    stroka4 += otmena4[i];
                                }
                            }
                            S = S.Remove(S.Length - count_stroka2);//удаляем

                            D++;
                            Undo[D] = stroka4; //запоминаем удаление
                            Operation[C] = stroka4;
                            C--; //т.к. мы отменили последнее действие 1 или 2 то из памчти вычищаем последнее действие 1 или 2
                        }

                        if (otmena4[0].ToString() == "2") //если последняяя операция была удалить то добавляем
                        {
                            string stroka4_2 = "1 ";

                            string stroka4_3 = Operation[C - 1].Substring(2, Math.Min(2,Operation[C - 1].Length - 2));
                            S += stroka4_3;

                            D++;
                            Undo[D] = stroka4_2 + stroka4_3; //запоминаем добавление
                            Operation[C] = stroka4_2 + stroka4_3;
                            C--;
                        }
                    }
                    return S;

                case 5:
                    if (Undo.Length == 0)
                        return S;
                    else
                    {
                        string otmena5 = Undo[D];
                        if (otmena5[0].ToString() == "1")
                        {
                            int count_stroka5 = 0;
                            string stroka5_1 = "2 ";
                            for (int i = 0; i < Undo[D].Length; i++)
                            {
                                if (i > 1)
                                {
                                    count_stroka5++;
                                    stroka5_1 += otmena5[i];
                                }
                            }
                            S = S.Remove(S.Length - count_stroka5);//удаляем
                        }
                        if (otmena5[0].ToString() == "2")
                        {
                            string stroka5_1 = "1 ";
                            for (int i = 0; i < Undo[D].Length; i++)
                            {
                                if (i > 1)
                                {
                                    stroka5_1 += otmena5[i];
                                }
                            }
                        }
                    }
                    return S;
            }
            return S;
        }
        #endregion

        static void Main()
        {
            string s;
            //s = Level1.BastShoe("1 Привет");
            //Console.WriteLine(s);//текущая строка
            //Console.WriteLine("1 Привет" + "А должно быть: " + "Привет");
            //Console.WriteLine();

            //s = Level1.BastShoe("1 , Мир!").ToString();
            //Console.WriteLine(s);
            //Console.WriteLine("1 , Мир!:  " + "А должно быть: " + "Привет, Мир!");
            //Console.WriteLine();

            //s = Level1.BastShoe("1 ++");
            //Console.WriteLine(s);
            //Console.WriteLine("1 ++:  " + "А должно быть: " + "Привет, Мир!++");
            //Console.WriteLine();

            //s = Level1.BastShoe("2 2");
            //Console.WriteLine(s);
            //Console.WriteLine("2 2:  " + "А должно быть: " + "Привет, Мир!");
            //Console.WriteLine();

            //s = Level1.BastShoe("4");
            //Console.WriteLine(s);
            //Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!++");
            //Console.WriteLine();

            //s = Level1.BastShoe("4");
            //Console.WriteLine(s);
            //Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            //Console.WriteLine();

            //s = Level1.BastShoe("1 *");
            //Console.WriteLine(s);
            //Console.WriteLine("1 *:  " + "А должно быть: " + "Привет, Мир!*");
            //Console.WriteLine();

            //s = Level1.BastShoe("4");
            //Console.WriteLine(s);
            //Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            //Console.WriteLine();

            //s = Level1.BastShoe("4");
            //Console.WriteLine(s);
            //Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            //Console.WriteLine();

            //s = Level1.BastShoe("4");
            //Console.WriteLine(s);
            //Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            //Console.WriteLine();

            //s = Level1.BastShoe("3 6");
            //Console.WriteLine(s);
            //Console.WriteLine("3 6:  " + "А должно быть: " + ",");
            //Console.WriteLine();

            //s = Level1.BastShoe("2 100");
            //Console.WriteLine(s);
            //Console.WriteLine("2 100:  " + "А должно быть: " + "");
            //Console.WriteLine();

            s = Level1.BastShoe("1 Привет");
            Console.WriteLine(s);//текущая строка
            Console.WriteLine("1 Привет:  " + "А должно быть: " + "Привет");
            Console.WriteLine();

            s = Level1.BastShoe("1 , Мир!").ToString();
            Console.WriteLine(s);
            Console.WriteLine("1 , Мир!:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("1 ++");
            Console.WriteLine(s);
            Console.WriteLine("1 ++:  " + "А должно быть: " + "Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine(s);
            Console.WriteLine("5:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("1 *");
            Console.WriteLine(s);
            Console.WriteLine("1 *:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine(s);
            Console.WriteLine("5:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine(s);
            Console.WriteLine("5:  " + "А должно быть: " + "Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine(s);
            Console.WriteLine("5:  " + "А должно быть: " + "Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine(s);
            Console.WriteLine("5:  " + "А должно быть: " + "Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет");
            Console.WriteLine();

            s = Level1.BastShoe("2 2");
            Console.WriteLine(s);
            Console.WriteLine("2 2:  " + "А должно быть: " + "Прив");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine(s);
            Console.WriteLine("5: " + "А должно быть: " + "Прив");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine(s);
            Console.WriteLine("5: " + "А должно быть: " + "Прив");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine(s);
            Console.WriteLine("5: " + "А должно быть: " + "Прив");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}