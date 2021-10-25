using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1 
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №19 "Автоматизация отчётности о продажах"
    /// </summary>
    [TestClass]
    public class Test_Level1
    {
        [TestMethod]
        [TestCategory("tests")]
        public void Test1()
        {
            int number = 1;
            int N = 5;
            string[] items = { "платье1 5", "сумка32 2", "платье1 1", "сумка23 2", "сумка128 4" };

            try
            {
                Console.WriteLine($"Кол-во {N}, массив:");
                foreach (string item in items)
                {
                    Console.WriteLine(" " + item);
                }
                Console.WriteLine();
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
                items = Level1.ShopOLAP(N, items);
                Console.WriteLine("Результат функции- ");
                foreach (string item in items)
                {
                    Console.WriteLine(" " + item);
                }
                Console.WriteLine();
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test2()
        {
            int number = 2;
            int N = 1;
            string[] items = { "платье1 5" };

            try
            {
                Console.WriteLine($"Кол-во {N}, массив:");
                foreach (string item in items)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
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
                items = Level1.ShopOLAP(N, items);
                Console.WriteLine("Результат функции- ");
                foreach (string item in items)
                {
                    Console.WriteLine(" " + item);
                }
                Console.WriteLine();
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test3()
        {
            int number = 3;
            int N = 8;
            string[] items = { "платье1 5", "сумка32 2", "платье1 1", "сумка23 2", "сумка128 4", "платье1 5", "платье1 5", "платье1 5" };

            try
            {
                Console.WriteLine($"Кол-во {N}, массив:");
                foreach (string item in items)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
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
                items = Level1.ShopOLAP(N, items);
                Console.WriteLine("Результат функции- ");
                foreach (string item in items)
                {
                    Console.WriteLine(" " + item);
                }
                Console.WriteLine();
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test4()
        {
            int number = 4;
            int N = 10;
            string[] items = { "платье1 5", "сумка32 2", "платье1 1", "сумка23 2", "сумка128 4", "платье1 5", "платье1 5", "платье1 5", "сумка128 7", "сумка32 2", "сумка30 1" };

            try
            {
                Console.WriteLine($"Кол-во {N}, массив:");
                foreach (string item in items)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
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
                items = Level1.ShopOLAP(N, items);
                Console.WriteLine("Результат функции- ");
                foreach (string item in items)
                {
                    Console.WriteLine(" " + item);
                }
                Console.WriteLine();
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test5()
        {
            int number = 5;
            int N = 12;
            string[] items = { "платье1 5", "сумка32 2", "платье1 1", "сумка23 2", "сумка128 4", "платье1 5", "платье1 5", "платье1 5", "сумка128 7", "сумка32 2", "сумка30 1", "сумка22 4", "сумка20 4" };

            try
            {
                Console.WriteLine($"Кол-во {N}, массив:");
                foreach (string item in items)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
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
                items = Level1.ShopOLAP(N, items);
                Console.WriteLine("Результат функции- ");
                foreach (string item in items)
                {
                    Console.WriteLine(" " + item);
                }
                Console.WriteLine();
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test6()
        {
            int number = 6;
            int N = 13;
            string[] items = { "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5", "платье1 5" };

            try
            {
                Console.WriteLine($"Кол-во {N}, массив:");
                foreach (string item in items)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
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
                items = Level1.ShopOLAP(N, items);
                Console.WriteLine("Результат функции- ");
                foreach (string item in items)
                {
                    Console.WriteLine(" " + item);
                }
                Console.WriteLine();
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test7()
        {
            int number = 7;
            int N = 5;
            string[] items = { "dress1 5", "handbug32 3", "dress2 1", "handbug23 2", "handbug128 4" };

            try
            {
                Console.WriteLine($"Кол-во {N}, массив:");
                foreach (string item in items)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
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
                items = Level1.ShopOLAP(N, items);
                Console.WriteLine("Результат функции- ");
                foreach (string item in items)
                {
                    Console.WriteLine(" " + item);
                }
                Console.WriteLine();
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
    }
}
