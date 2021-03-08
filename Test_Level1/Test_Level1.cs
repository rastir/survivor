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
        [TestCategory("tests")]
        public void Test2()
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
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST 2 ERROR");
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
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
                Console.WriteLine("TEST 2 PASSED");
            }
        }
    }
}
