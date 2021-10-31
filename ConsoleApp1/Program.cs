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
        public static List<commands> rrr = new List<commands>();

        public class commands {
            public int command = 0;
            public bool isUndo;
            public string str = "";
            public string Undostr = "";
            public int Undocommand = 0;

        }

        public static string S = "";//текущая строка
        public static string comanda = "";//текущая команда
        //public static int C = 0; //храним все действия Operation
        //public static int D = 0;//храним все действия Undo 
       // public static string[] Operation = new string[100000];
        //public static string[] Undo = new string[100000];

        public static string BastShoe(string command)
        {
            if (command == "") return S;
            char[] massiv = command.ToCharArray();
            int burr = Convert.ToInt32(command.Substring(0, 1));

            comanda = command.Length > 1 ? command.Substring(2) : "";

            switch (burr)
            {
                case 1:
                    if (rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4) { rrr.Clear(); rrr = new List<commands>(); } //rrr = new List<commands>(); }
                    commands op = new commands();
                    op.command = burr;
                    op.str = comanda;
                    rrr.Add(op);
                    S += comanda;

                    return S;

                case 2:
                    try
                    {
                        var second2 = Convert.ToInt16(comanda.Trim());
                        commands op2 = new commands();
                        op2.Undostr = S.Substring(S.Length - Math.Min(S.Length, second2));
                        S = S.Remove(S.Length - Math.Min(S.Length, second2));
                        if (rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4) { rrr.Clear(); rrr = new List<commands>(); }// rrr = new List<commands>(); }
                        op2.command = burr;
                        op2.str = comanda;
                        rrr.Add(op2);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    return S;

                case 3:
                    string[] words3 = command.Split(" ");
                    int second3 = Convert.ToInt32(words3[1]);
                    if (second3 > S.Length)
                        return "";
                    else
                        return S[second3].ToString();

                case 4:
                    {
                        var last4 = rrr.FindLast(t => t.isUndo == false /*&& t.str==""*/ && (t.command == 1 || t.command == 2));
                        if (last4 != null)
                        {
                            commands op4 = new commands();
                            if (last4.command == 1)
                            {
                                if (S.EndsWith(last4.str))
                                    S = S.Substring(0, S.Length - last4.str.Length);
                            }
                            if (last4.command == 2)
                            {
                                S += last4.Undostr;
                            }
                            op4.Undostr = last4.str;
                            op4.Undocommand = last4.command;
                            last4.isUndo = true;

                        }
                    }
                    return S;       
                case 5:
                    var last5 = rrr.FindLast(t => t.isUndo == false && t.command == 4);
                    if (last5 != null) 
                    {
                        if (last5.Undocommand == 1) { S += last5.Undostr; }
                        if (last5.Undocommand == 2) {
                            if (S.EndsWith(last5.str))
                                S.Substring(0, S.Length - last5.str.Length);
                        }
                        last5.isUndo = true;
                    }
                    return S;
            }
            return S;
        }
        #endregion

        static void Main()
        {
            string s;
            s = Level1.BastShoe("1 Привет");
            Console.WriteLine(s);//текущая строка
            Console.WriteLine("1 Привет:   " + "А должно быть: " + "Привет");
            Console.WriteLine();

            s = Level1.BastShoe("1 , Мир!").ToString();
            Console.WriteLine(s);
            Console.WriteLine("1 , Мир!:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("1 ++");
            Console.WriteLine(s);
            Console.WriteLine("1 ++:  " + "А должно быть: " + "Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("2 2");
            Console.WriteLine(s);
            Console.WriteLine("2 2:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("1 *");
            Console.WriteLine(s);
            Console.WriteLine("1 *:  " + "А должно быть: " + "Привет, Мир!*");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "А должно быть: " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("3 6");
            Console.WriteLine(s);
            Console.WriteLine("3 6:  " + "А должно быть: " + ",");
            Console.WriteLine();

            s = Level1.BastShoe("2 100");
            Console.WriteLine(s);
            Console.WriteLine("2 100:  " + "А должно быть: " + "");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}