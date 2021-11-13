using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №22 "Древо Жизни Андрассил"
    /// </summary>
    [TestClass]
    public class Test_Level1
    {
        [TestMethod]
        [TestCategory("tests")]
        public void Test1()
        {
            int number = 1;

            string[] array = { ".+..", "..+.", ".+.." };
            int H = 3;
            int W = 4;
            int N = 12;

            try
            {
                Level1.TreeOfLife(H, W, N, array);
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
                array = Level1.TreeOfLife(H, W, N, array);

                Console.WriteLine("результат:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(" " + array[i]);
                }

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test2()
        {
            int number = 2;

            string[] array = { "++++", "++++", "++++" };
            int H = 3;
            int W = 4;
            int N = 12;

            try
            {
                Level1.TreeOfLife(H, W, N, array);
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
                array = Level1.TreeOfLife(H, W, N, array);

                Console.WriteLine("результат:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(" " + array[i]);
                }

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test3()
        {
            int number = 3;

            string[] array = { "....", "....", "...." };
            int H = 3;
            int W = 4;
            int N = 12;

            try
            {
                Level1.TreeOfLife(H, W, N, array);
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
                array = Level1.TreeOfLife(H, W, N, array);

                Console.WriteLine("результат:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(" " + array[i]);
                }

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test4()
        {
            int number = 4;

            string[] array = { "....", "++++", "...." };
            int H = 3;
            int W = 4;
            int N = 12;

            try
            {
                Level1.TreeOfLife(H, W, N, array);
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
                array = Level1.TreeOfLife(H, W, N, array);

                Console.WriteLine("результат:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(" " + array[i]);
                }

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
    }
}