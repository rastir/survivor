using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    /// <summary>
    /// Тесты для задания №6 Level1 "Курс 28 заданий"
    /// </summary>
    [TestClass]
    public class Test_Level1
    {
        [TestMethod]
        public void Test2()
        {
            try
            {
                int[] findword = Level1.WordSearch(1, "10", "1");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 1, 10, 1 ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        /// <summary> Test3 - 1 </summary>
        public void Test3()
        {
            try
            {
                int[] findword = Level1.WordSearch(1, "1", "1");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 1, 1, 1 ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test4 - 123</summary>
        public void Test4()
        {
            try
            {
                int[] findword = Level1.WordSearch(1, "123", "1");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 1, 123, 1 ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test5 - 12345</summary>
        public void Test5()
        {
            try
            {
                int[] findword = Level1.WordSearch(3, "12345", "123");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 3, 12345, 123 ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test6 - 12345</summary>
        public void Test6()
        {
            try
            {
                int[] findword = Level1.WordSearch(3, "1234567890000000000", "123");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 3, 1234567890000000000   123 ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test7 - 12345</summary>
        public void Test7()
        {
            try
            {
                int[] findword = Level1.WordSearch(12, "1) строк разбивается на набор строк через выравнивание по заданной ширине.", "строк");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 12, \"1) строк разбивается на набор строк через выравнивание по заданной ширине.    строк ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test8 - 12345</summary>
        public void Test8()
        {
            try
            {
                int[] findword = Level1.WordSearch(12, "1) строка разбивается на набор строк через выравнивание по заданной ширине.", "строк");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 12, \"1) строка разбивается на набор строк через выравнивание по заданной ширине. строк ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test9 - 12345</summary>
        public void Test9()
        {
            try
            {
                int[] findword = Level1.WordSearch(4, "1) строчапывапвапвыапывака разбивается на набор строкывапывапывапывап через выравнивание по заданной ширывапывапывапывапине.", "строк");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 4, 1) строчапывапвапвыапывака разбивается на набор строкывапывапывапывап через выравнивание по заданной ширывапывапывапывапине.       строк ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test10 - 10, "12345", "subs" </summary>
        public void Test10()
        {
            try
            {
                int[] findword = Level1.WordSearch(10, "12345", "subs");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 10, 12345, subs  ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test11 - 10, "12345", "srrrrubs" </summary>
        public void Test11()
        {
            try
            {
                int[] findword = Level1.WordSearch(10, "12345", "srrrrubs");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 10, 12345   srrrrubs ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test12 - 2, "123 456 7899 99", "99" </summary>
        public void Test12()
        {
            try
            {
                int[] findword = Level1.WordSearch(2, "123 456 7899 99", "99");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 2, \"123 456 7899 99", "99\" ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        /// <summary> Test13 - 3, "123 456 7899 99", "99" </summary>
        public void Test13()
        {
            try
            {
                int[] findword = Level1.WordSearch(3, "123 456 7899 99", "99");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 3, \"123 456 7899 99", "99\" ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }

        [TestMethod]
        public void Test14()
        {
            try
            {
                int[] findword = Level1.WordSearch(2, "10", "1");
                for (int i = 0; i < findword.Length; i++)
                {
                    Console.Write(findword[i] + " ");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("на вход -- 2, 10, 1 ");
                Console.WriteLine("TEST 2 PASSED");
            }
        }
    }
}
