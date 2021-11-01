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
                Console.WriteLine($"{s}");
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

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test2()
        {
            int number = 2;
            string s2 = "";

            try
            {
                Console.WriteLine($"{s2}");
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

                s2 = Level1.BastShoe("1 Привет");
                Console.WriteLine("1 Привет");
                Console.WriteLine(s2);
                Console.WriteLine("Привет");
                Console.WriteLine();

                s2 = Level1.BastShoe("5 , Мир!");
                Console.WriteLine("5 , Мир!");
                Console.WriteLine(s2);
                Console.WriteLine("Привет");
                Console.WriteLine();

                s2 = Level1.BastShoe("4 ++");
                Console.WriteLine("4 ++");
                Console.WriteLine(s2);
                Console.WriteLine("Привет");
                Console.WriteLine();

                s2 = Level1.BastShoe("3");
                Console.WriteLine("3");
                Console.WriteLine(s2);
                Console.WriteLine("Привет");
                Console.WriteLine();

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test3()
        {
            int number = 3;
            string s3 = "";

            try
            {
                Console.WriteLine($"{s3}");
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
                s3= Level1.BastShoe("1 Привет");
                Console.WriteLine("1 Привет");
                Console.WriteLine(s3);
                Console.WriteLine("Привет");
                Console.WriteLine();

                s3= Level1.BastShoe("1 , Мир!");
                Console.WriteLine("1 , Мир!");
                Console.WriteLine(s3);
                Console.WriteLine("Привет, Мир!");
                Console.WriteLine();

                s3= Level1.BastShoe("1 ++");
                Console.WriteLine("1 ++");
                Console.WriteLine(s3);
                Console.WriteLine("Привет, Мир!++");
                Console.WriteLine();

                s3= Level1.BastShoe("4");
                Console.WriteLine("4");
                Console.WriteLine(s3);
                Console.WriteLine("4:  " + "Привет, Мир!");
                Console.WriteLine();

                s3= Level1.BastShoe("4");
                Console.WriteLine("4");
                Console.WriteLine(s3);
                Console.WriteLine("Привет");
                Console.WriteLine();

                s3= Level1.BastShoe("5");
                Console.WriteLine("5");
                Console.WriteLine(s3);
                Console.WriteLine("Привет, Мир!");
                Console.WriteLine();

                s3= Level1.BastShoe("4");
                Console.WriteLine("4");
                Console.WriteLine(s3);
                Console.WriteLine("Привет");
                Console.WriteLine();

                s3= Level1.BastShoe("5");
                Console.WriteLine("5");
                Console.WriteLine(s3);
                Console.WriteLine("Привет, Мир!");
                Console.WriteLine();

                s3= Level1.BastShoe("5");
                Console.WriteLine("5");
                Console.WriteLine(s3);
                Console.WriteLine("Привет, Мир!++");
                Console.WriteLine();

                s3= Level1.BastShoe("5");
                Console.WriteLine("5");
                Console.WriteLine(s3);
                Console.WriteLine("Привет, Мир!++");
                Console.WriteLine();

                s3= Level1.BastShoe("5");
                Console.WriteLine("5");
                Console.WriteLine(s3);
                Console.WriteLine("Привет, Мир!++");
                Console.WriteLine();

                s3= Level1.BastShoe("4");
                Console.WriteLine("4");
                Console.WriteLine(s3);
                Console.WriteLine("Привет, Мир!");
                Console.WriteLine();

                s3= Level1.BastShoe("4");
                Console.WriteLine("4");
                Console.WriteLine(s3);
                Console.WriteLine("Привет");
                Console.WriteLine();

                s3= Level1.BastShoe("2 2");
                Console.WriteLine("2 2");
                Console.WriteLine(s3);
                Console.WriteLine("Прив");
                Console.WriteLine();

                s3= Level1.BastShoe("4");
                Console.WriteLine("4");
                Console.WriteLine(s3);
                Console.WriteLine("Привет");
                Console.WriteLine();

                s3= Level1.BastShoe("5");
                Console.WriteLine("5");
                Console.WriteLine(s3);
                Console.WriteLine("Прив");
                Console.WriteLine();

                s3= Level1.BastShoe("5");
                Console.WriteLine("5");
                Console.WriteLine(s3);
                Console.WriteLine("Прив");
                Console.WriteLine();

                s3= Level1.BastShoe("5");
                Console.WriteLine("5");
                Console.WriteLine(s3);
                Console.WriteLine("Прив");
                Console.WriteLine();

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
    }
}
