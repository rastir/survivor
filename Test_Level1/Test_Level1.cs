using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №20 "Делаем национальный редактор "Лапоть""
    /// </summary>
    [TestClass]
    public class Test_Level1
    {
        [TestMethod]
        [TestCategory("tests")]
        public void Test1()
        {
            int number = 1;
            string s = "";

            try
            {
                Console.WriteLine($"Кол-во {s}, массив:");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST {0} ERROR", number);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST {0} ERROR", number);
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {

                s = Level1.BastShoe("1 Привет");
                Console.WriteLine(s);//текущая строка
                Console.WriteLine("1 Привет" + "А должно быть: " + "Привет");
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

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test2()
        {
            int number = 2;
            string s = "";

            try
            {
                Console.WriteLine($"Кол-во {s}, массив:");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST {0} ERROR", number);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST {0} ERROR", number);
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {

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

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }


        [TestMethod]
        [TestCategory("tests")]
        public void Test3()
        {
            int number = 3;
            string s = "";

            try
            {
                Console.WriteLine($"Кол-во {s}, массив:");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST {0} ERROR", number);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST {0} ERROR", number);
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {

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

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
    }
}
