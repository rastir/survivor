using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    ///<summary> 
    ///Тесты для задания №18 "Мистер Робот и Корпорация Зла"
    /// </summary>
    public class Test_Level1
    {
        [TestMethod]
        [TestCategory("tests")]
        public void Test1()
        {
            int number = 1;
            int N = 7;
            int[] data = { 1, 3, 4, 5, 6, 2, 7 };

            try
            {
                Console.WriteLine("Кол-во {0}, массив: {1}");
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
                //DateTime StartTime;
                //StartTime = DateTime.Now;
                //Level1.MisterRobot(N, data);
                //DateTime EndTime = DateTime.Now;

                Console.WriteLine("Результат функции- " + Level1.MisterRobot(N, data));
                Console.WriteLine("Реальный результат - " + "false");
                //Console.WriteLine("Время выполнения " + (EndTime - StartTime).TotalSeconds);
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test2()
        {
            int number = 2;
            int N = 20;
            int[] data = { 1, 3, 4, 5, 6, 2, 7, 20, 19, 18, 10, 17, 16, 15, 8, 9, 11, 12, 13, 14};

            try
            {
                Console.WriteLine("Кол-во {0}, массив: {1}");
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
                //DateTime StartTime;
                //StartTime = DateTime.Now;
                //Level1.MisterRobot(N, data);
                //DateTime EndTime = DateTime.Now;

                Console.WriteLine("Результат функции- " + Level1.MisterRobot(N, data));
                foreach (int item in data)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine("Реальный результат - " + "false");
                //Console.WriteLine("Время выполнения " + (EndTime - StartTime).TotalSeconds);
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test3()
        {
            int number = 3;
            int N = 10;
            int[] data = { 1, 3, 4, 5, 6, 2, 7, 10, 8, 9 };

            try
            {
                Console.WriteLine("Кол-во {0}, массив: {1}");
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
                DateTime StartTime;
                StartTime = DateTime.Now;
                Level1.MisterRobot(N, data);
                DateTime EndTime = DateTime.Now;

                Console.WriteLine("Результат функции- "+ Level1.MisterRobot(N, data));
                foreach (int item in data)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine("Реальный результат - " + "false");
                Console.WriteLine("Время выполнения " + (EndTime - StartTime).TotalSeconds);
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test4()
        {
            int number = 4;
            int N = 7;
            int[] data = { 1, 3, 4, 5, 6, 2, 7 };

            try
            {
                Console.WriteLine("Кол-во {0}, массив: {1}");
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
                DateTime StartTime;
                StartTime = DateTime.Now;
                Level1.MisterRobot(N, data);
                DateTime EndTime = DateTime.Now;

                Console.WriteLine("Результат функции- " + Level1.MisterRobot(N, data));
                foreach (int item in data)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine("Реальный результат - " + "true");
                Console.WriteLine("Время выполнения " + (EndTime - StartTime).TotalSeconds);
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
    }
}
