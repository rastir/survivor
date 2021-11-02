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
        public static List<Commands> rrr = new List<Commands>();

        public class Commands
        {
            public int command = 0;
            public bool isUndo;
            public string str = "";
            public string str2 = "";
            public string Undostr = "";
            public int Undocommand = 0;
//            public bool Cursor = false;
        }

        public static int Cursor = 0;
        public static bool LastCursor = false;
        public static string S = "";
        public static string comanda = "";

        public static string BastShoe(string command)
        {
            if (command == "")
                return S;

            char[] massiv = command.ToCharArray();
            int burr = Convert.ToInt32(command.Substring(0, 1));

            comanda = command.Length > 1 ? command.Substring(2) : "";

            if (burr != 1 && burr != 2 && burr != 3 && burr != 4 && burr != 5)
                return S;

            if ((burr == 1 || burr == 2 || burr == 3) && command.Length < 3)
                return S;

            if ((burr == 4 || burr == 5) && command.Length > 1)
                return S;

            switch (burr)
            {
                case 1:

                    
                    Commands op = new Commands();
                    op.command = burr;
                    op.str = comanda;
                    rrr.Add(op);
                    S += comanda;
                    op.str2 = S;
                    int temp = Cursor;
                    Cursor = rrr.IndexOf(op);
                    if (LastCursor)//(rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4)
                    {
                        for (int i = Cursor - 1; i > -1; i--)
                        {
                            if (i != temp)
                                rrr.RemoveAt(i);
                        }
                        Cursor = rrr.Count - 1;
                    }
                    LastCursor = false;
                    return S;

                case 2:
                    //try
                    //{
                        var second2 = Convert.ToInt16(comanda.Trim());
                        Commands op2 = new Commands();
                        op2.Undostr = S.Substring(S.Length - Math.Min(S.Length, second2));
                        S = S.Remove(S.Length - Math.Min(S.Length, second2));
                        op2.str2 = S;                   
                        op2.command = burr;
                        op2.str = comanda;
                        rrr.Add(op2);
                        int temp2 = Cursor;
                        Cursor = rrr.IndexOf(op2);
                        if (LastCursor)//(rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4)
                        {
                            
                            for (int i = Cursor - 1; i > -1; i--)
                            {
                                if (i != temp2)
                                rrr.RemoveAt(i);
                            }
                            Cursor = rrr.Count - 1;
                    }
                        LastCursor = false;
                    //}

                    //catch (Exception)
                    //{

                    //    throw;
                    //}
                    return S;

                case 3:
                    //Commands op3 = new Commands();
                    //op3.command = burr;
                    //op3.str = comanda;
                    //rrr.Add(op3);
                    if (Convert.ToInt32(comanda) > S.Length)
                        return "";
                    else
                        return S[Convert.ToInt32(comanda)].ToString();
                    LastCursor = false;

                case 4:
                    {
                        var last4 = rrr.FindLast(t => t.isUndo == false && (t.command == 1 || t.command == 2));

                        if (last4 != null)
                        {
                            //Commands op4 = new Commands();
                            //if (last4.command == 1)
                            //{
                            //    if (S.EndsWith(last4.str))
                            //        S = S.Substring(0, S.Length - last4.str.Length);
                            //}
                            //if (last4.command == 2)
                            //{
                            //    S += last4.Undostr;
                            //}
                            // op4.str = last4.Undostr;
                            //op4.Undostr = last4.str;
                            //op4.command = burr;
                            //op4.Undocommand = last4.command;
                            //last4.isUndo = true;
                            //rrr.Add(op4);
                            LastCursor = true;
                            //Cursor = rrr.IndexOf(op4);
                            if (Cursor - 1 >= 0)
                                Cursor--;
                            S = rrr[Cursor].str2;
                        }
                    }
                    return S;
                case 5:
                    //var last5 = rrr.FindLast(t => t.isUndo == false && t.command == 4);
                    var last5 = rrr[Cursor]; //rrr.FindIndex(t => rrr[Cursor]);    //rrr.FindLast(t => rrr.IndexOf(t)=Cursor && ( t.command == 1 || t.command == 2));
                    if (last5 != null)
                    {
                        //Commands op5 = new Commands();
                        //if (last5.Undocommand == 1)
                        //{
                        //    S += last5.Undostr;
                        //    op5.Undocommand = 0;
                        //    op5.Undostr = "";
                        //    op5.command = 1;
                        //    op5.str = last5.Undostr;
                        //}
                        //if (last5.Undocommand == 2)
                        //{
                        //    if (S.EndsWith(last5.str))
                        //        S = S.Substring(0, S.Length - last5.str.Length);
                        //    op5.Undocommand = 0;
                        //    op5.Undostr = "";
                        //    op5.command = 2;
                        //    op5.str = last5.Undostr;
                        //}
                        //last5.isUndo = true;
                        //rrr.Add(op5);
                        //if (rrr.Count - 1 <= rrr[Cursor] + 1)
                        // Cursor = rrr[Cursor] + 1;
                        if (Cursor + 1 <= rrr.Count - 1 )
                            Cursor++;
                        //S = rrr[Cursor].Undocommand.ToString() + " " + rrr[Cursor].Undostr.ToString();
                        S = rrr[Cursor].str2;
                        LastCursor = false;
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
            Console.WriteLine("1 Привет");
            Console.WriteLine(s);
            Console.WriteLine("Привет");
            Console.WriteLine();

            s = Level1.BastShoe("1 , Мир!");
            Console.WriteLine("1 , Мир!");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("1 ++");
            Console.WriteLine("1 ++");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("2 2");
            Console.WriteLine("2 2");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("1 *");
            Console.WriteLine("1 *");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!*");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("3 6");
            Console.WriteLine("3 6");
            Console.WriteLine(s);
            Console.WriteLine(",");
            Console.WriteLine();

            s = Level1.BastShoe("2 100");
            Console.WriteLine("2 100");
            Console.WriteLine(s);
            Console.WriteLine("");
            Console.WriteLine();

            s = Level1.BastShoe("1 Привет");
            Console.WriteLine("1 Привет");
            Console.WriteLine(s);
            Console.WriteLine("Привет");
            Console.WriteLine();

            s = Level1.BastShoe("1 , Мир!");
            Console.WriteLine("1 , Мир!");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("1 ++");
            Console.WriteLine("1 ++");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("4:  " + "Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine("5");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine("5");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine("5");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine("5");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine("5");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!++");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет, Мир!");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет");
            Console.WriteLine();

            s = Level1.BastShoe("2 2");
            Console.WriteLine("2 2");
            Console.WriteLine(s);
            Console.WriteLine("Прив");
            Console.WriteLine();

            s = Level1.BastShoe("4");
            Console.WriteLine("4");
            Console.WriteLine(s);
            Console.WriteLine("Привет");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine("5");
            Console.WriteLine(s);
            Console.WriteLine("Прив");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine("5");
            Console.WriteLine(s);
            Console.WriteLine("Прив");
            Console.WriteLine();

            s = Level1.BastShoe("5");
            Console.WriteLine("5");
            Console.WriteLine(s);
            Console.WriteLine("Прив");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}