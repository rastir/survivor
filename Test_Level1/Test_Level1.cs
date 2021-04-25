using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    /// <summary>
    /// Тесты для задания №6 Level1 "Курс 28 заданий"
    /// </summary>
    [TestClass]
    #region
    //public class Test_Level1
    //{
    //    [TestMethod]
    //    public void Test2()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(1, "10", "1");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 1, 10, 1 ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test3 - 1 </summary>
    //    public void Test3()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(1, "1", "1");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 1, 1, 1 ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test4 - 123</summary>
    //    public void Test4()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(1, "123", "1");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 1, 123, 1 ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test5 - 12345</summary>
    //    public void Test5()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(3, "12345", "123");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 3, 12345, 123 ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test6 - 12345</summary>
    //    public void Test6()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(3, "1234567890000000000", "123");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 3, 1234567890000000000   123 ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test7 - 12345</summary>
    //    public void Test7()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(12, "1) строк разбивается на набор строк через выравнивание по заданной ширине.", "строк");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 12, \"1) строк разбивается на набор строк через выравнивание по заданной ширине.    строк ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test8 - 12345</summary>
    //    public void Test8()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(12, "1) строка разбивается на набор строк через выравнивание по заданной ширине.", "строк");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 12, \"1) строка разбивается на набор строк через выравнивание по заданной ширине. строк ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test9 - 12345</summary>
    //    public void Test9()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(4, "1) строчапывапвапвыапывака разбивается на набор строкывапывапывапывап через выравнивание по заданной ширывапывапывапывапине.", "строк");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 4, 1) строчапывапвапвыапывака разбивается на набор строкывапывапывапывап через выравнивание по заданной ширывапывапывапывапине.       строк ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test10 - 10, "12345", "subs" </summary>
    //    public void Test10()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(10, "12345", "subs");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 10, 12345, subs  ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test11 - 10, "12345", "srrrrubs" </summary>
    //    public void Test11()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(10, "12345", "srrrrubs");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 10, 12345   srrrrubs ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test12 - 2, "123 456 7899 99", "99" </summary>
    //    public void Test12()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(2, "123 456 7899 99", "99");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 2, \"123 456 7899 99", "99\" ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    /// <summary> Test13 - 3, "123 456 7899 99", "99" </summary>
    //    public void Test13()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(3, "123 456 7899 99", "99");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 3, \"123 456 7899 99", "99\" ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }

    //    [TestMethod]
    //    public void Test14()
    //    {
    //        try
    //        {
    //            int[] findword = Level1.WordSearch(2, "10", "1");
    //            for (int i = 0; i < findword.Length; i++)
    //            {
    //                Console.Write(findword[i] + " ");
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("на вход -- 2, 10, 1 ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }
    //}
    #endregion
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №11 "Райнехарт и мистер Андерсон"
    /// </summary>
    #region
    //public class Test_Level1
    //{
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test1()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("1234567891", "543216540");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Входные данные "+"1) 1234567891 " + " 2) 543216540");
    //            Console.WriteLine("TEST 1 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test3 - 1 </summary>
    //    public void Test2()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("0", "0");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 0 " + " 2) 0");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test3 - 1 </summary>
    //    public void Test3()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("1", "0");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 3 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 3 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 1 " + " 2) 0");
    //            Console.WriteLine("TEST 3 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test3 - 1 </summary>
    //    public void Test4()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("10000000000000000", "10000000000000000");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 4 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 4 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 10000000000000000 " + " 2) 10000000000000000");
    //            Console.WriteLine("TEST 4 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test5 - 1 </summary>
    //    public void Test5()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("1234567891", "1");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 5 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 5 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 1234567891 " + " 2) 1");
    //            Console.WriteLine("TEST 5 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test5 - 1 </summary>
    //    public void Test6()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("0", "1");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 6 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 6 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 0 " + " 2) 1");
    //            Console.WriteLine("TEST 6 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test7 - 1 </summary>
    //    public void Test7()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("1234567890", "321");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 7 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 7 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 1234567890 " + " 2) 321");
    //            Console.WriteLine("TEST 7 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test8 - 1 </summary>
    //    public void Test8()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("1", "321");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 8 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 8 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 1 " + " 2) 321");
    //            Console.WriteLine("TEST 8 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test9 - 1 </summary>
    //    public void Test9()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("321", "1");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 9 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 9 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 321 " + " 2) 1");
    //            Console.WriteLine("TEST 9 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test10 - 1 </summary>
    //    public void Test10()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("0", "11");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 10 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 10 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 0 " + " 2) 11");
    //            Console.WriteLine("TEST 10 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test11 - 1 </summary>
    //    public void Test11()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("1", "32111");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 11 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 11 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 1 " + " 2) 32111");
    //            Console.WriteLine("TEST 11 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test11 - 1 </summary>
    //    public void Test12()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("112", "32111");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 12 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 12 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 112 " + " 2) 32111");
    //            Console.WriteLine("TEST 12 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test13 - 1 </summary>
    //    public void Test13()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("101011001", "10000000001");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 13 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 13 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 101011001 " + " 2) 10000000001");
    //            Console.WriteLine("TEST 13 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test14 - 1 </summary>
    //    public void Test14()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("10000000001", "101011001");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 14 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 14 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 10000000001 " + " 2) 101011001");
    //            Console.WriteLine("TEST 14 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test15 - 1 </summary>
    //    public void Test15()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("10001", "101");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 15 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 15 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 10001 " + " 2) 101");
    //            Console.WriteLine("TEST 15 PASSED");
    //        }
    //    }
    //    //  
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test16 - 1 </summary>
    //    public void Test16()
    //    {
    //        try
    //        {
    //            string result = Level1.BigMinus("1100019", "789011");
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 16 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 16 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Входные данные " + "1) 1100019 " + " 2) 789011");
    //            Console.WriteLine("TEST 16 PASSED");
    //        }
    //    }
    #endregion

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №12 "146%"
    /// </summary>
    #region
    //public class Test_Level1
    //{
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test1()
    //    {
    //        try
    //        {
    //            int N = 5;
    //            int[] Votes = { 60, 10, 10, 15, 5 };
    //            string result = Level1.MassVote(N, Votes);
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 1 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 1 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Входные данные " + "5 " + " { 60, 10, 10, 15, 5 } ");
    //            Console.WriteLine("TEST 1 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test3 - 1 </summary>
    //    public void Test2()
    //    {
    //        try
    //        {
    //            int N = 1;
    //            int[] Votes = { 1 };
    //            string result = Level1.MassVote(N, Votes);
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Входные данные " + "1 " + " { 1 } ");
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test3 - 1 </summary>
    //    public void Test3()
    //    {
    //        try
    //        {
    //            int N = 3;
    //            int[] Votes = { 60, 60, 60 };
    //            string result = Level1.MassVote(N, Votes);
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 3 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 3 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Входные данные " + "3 " + " { 60, 60, 60 } ");
    //            Console.WriteLine("TEST 3 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test3 - 1 </summary>
    //    public void Test4()
    //    {
    //        try
    //        {
    //            int N = 5;
    //            int[] Votes = { 1, 2, 111, 111, 110 };
    //            string result = Level1.MassVote(N, Votes);
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 4 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 4 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Входные данные " + "5 " + " { 1,2,111,111,110 } ");
    //            Console.WriteLine("TEST 4 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test5 - 1 </summary>
    //    public void Test5()
    //    {
    //        try
    //        {
    //            int N = 2;
    //            int[] Votes = { 1,1 };
    //            string result = Level1.MassVote(N, Votes);
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 5 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 5 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Входные данные " + "2 " + " { 1,1 } ");
    //            Console.WriteLine("TEST 5 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test5 - 1 </summary>
    //    public void Test6()
    //    {
    //        try
    //        {
    //            int N = 3;
    //            int[] Votes = { 10,15,10 };
    //            string result = Level1.MassVote(N, Votes);
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 6 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 6 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Входные данные " + "5 " + " { 10,15,10 } ");
    //            Console.WriteLine("TEST 6 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    /// <summary> Test5 - 1 </summary>
    //    public void Test7()
    //    {
    //        try
    //        {
    //            int N = 4;
    //            int[] Votes = { 111, 111, 110,110 };
    //            string result = Level1.MassVote(N, Votes);
    //            Console.WriteLine("Результат " + result);
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 7 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 7 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Входные данные " + "4 " + " { 111, 111, 110,110 } ");
    //            Console.WriteLine("TEST 7 PASSED");
    //        }
    //    }
    #endregion
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №13 "Сигналы НЛО"
    /// </summary>
    #region
    //public class Test_Level1
    //{
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test1()
    //    {
    //        try
    //        {
    //            int N = 2;
    //            int[] data = { 1234, 1777 };
    //            bool octal = true; //8

    //            for (int i = 0; i < N; i++)
    //            {
    //                Console.WriteLine("Результат{0}- " + Level1.UFO(N, data, octal)[i] + " ", i + 1);
    //            }                
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 1 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 1 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            int N = 2;
    //            int[] data = { 1234, 1777 };
    //            bool octal = true; //8
    //            Console.WriteLine("Система: {0}" + "--" + "Длина траффика " + N + "---------" + "Исходный массив ",octal);
    //            for (int i = 0; i < data.Length; i++)
    //            {
    //                Console.Write(" " + data[i]);
    //            }
    //            Console.WriteLine();
    //            Console.WriteLine("TEST 1 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test2()
    //    {
    //        try
    //        {
    //            int N = 2;
    //            int[] data = { 1234, 1777 };
    //            bool octal = false; //16

    //            for (int i = 0; i < N; i++)
    //            {
    //                Console.WriteLine("Результат{0}- " + Level1.UFO(N, data, octal)[i] + " ", i + 1);
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 2 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            int N = 2;
    //            int[] data = { 1234, 1777 };
    //            bool octal = false; //166
    //            Console.WriteLine("Система: {0}"+"--"+"Длина траффика " + N+ "---------"+"Исходный массив ",octal);
    //            for (int i = 0; i < data.Length; i++)
    //            {
    //                Console.Write(" " + data[i]);
    //            }
    //            Console.WriteLine();
    //            Console.WriteLine("TEST 2 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test3()
    //    {
    //        int N = 1;
    //        int[] data = { 1234 };
    //        bool octal = true; //8
    //        try
    //        {
    //            for (int i = 0; i < N; i++)
    //            {
    //                Console.WriteLine("Результат{0}- " + Level1.UFO(N, data, octal)[i] + " ", i + 1);
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 3 ERROR");
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST 3 ERROR");
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Система: {0}" + "--" + "Длина траффика " + N + "---------" + "Исходный массив ", octal);
    //            for (int i = 0; i < data.Length; i++)
    //            {
    //                Console.Write(" " + data[i]);
    //            }
    //            Console.WriteLine();
    //            Console.WriteLine("TEST 3 PASSED");
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test4()
    //    {
    //        int k = 4;//номер теста
    //        int N = 1;
    //        int[] data = { 1234 };
    //        bool octal = false; //16
    //        try
    //        {
    //            for (int i = 0; i < N; i++)
    //            {
    //                Console.WriteLine("Результат{0}- " + Level1.UFO(N, data, octal)[i] + " ", i + 1);
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR",k);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR",k);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Система: {0}" + "--" + "Длина траффика " + N + "---------" + "Исходный массив ", octal);
    //            for (int i = 0; i < data.Length; i++)
    //            {
    //                Console.Write(" " + data[i]);
    //            }
    //            Console.WriteLine();
    //            Console.WriteLine("TEST {0} PASSED",k);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test5()
    //    {
    //        int k = 5;//номер теста
    //        int N = 1;
    //        int[] data = { 2147473647 };
    //        bool octal = true; //8
    //        try
    //        {
    //            for (int i = 0; i < N; i++)
    //            {
    //                Console.WriteLine("Результат{0}- " + Level1.UFO(N, data, octal)[i] + " ", i + 1);
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", k);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", k);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Система: {0}" + "--" + "Длина траффика " + N + "---------" + "Исходный массив ", octal);
    //            for (int i = 0; i < data.Length; i++)
    //            {
    //                Console.Write(" " + data[i]);
    //            }
    //            Console.WriteLine();
    //            Console.WriteLine("TEST {0} PASSED", k);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test6()
    //    {
    //        int k = 6;//номер теста
    //        int N = 1;
    //        int[] data = { 2147473647 };
    //        bool octal = false; //16
    //        try
    //        {
    //            for (int i = 0; i < N; i++)
    //            {
    //                Console.WriteLine("Результат{0}- " + Level1.UFO(N, data, octal)[i] + " ", i + 1);
    //            }
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", k);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", k);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Система: {0}" + "--" + "Длина траффика " + N + "---------" + "Исходный массив ", octal);
    //            for (int i = 0; i < data.Length; i++)
    //            {
    //                Console.Write(" " + data[i]);
    //            }
    //            Console.WriteLine();
    //            Console.WriteLine("TEST {0} PASSED", k);
    //        }
    //    }
    #endregion
    //}
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №14 "Оптимизация беспилотного трафика"
    /// </summary>
    #region
    public class Test_Level1
    {
        [TestMethod]
        [TestCategory("tests")]
        public void Test1()
        {
            int number = 1;

            int L = 10;
            int N = 2;
            int[][] track = new int[2][];
            track[1] = new[] { 3, 5, 5 };
            track[0] = new[] { 5, 2, 2 };

            try
            {
                Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
                Console.WriteLine("ОПисание дороги ");
                for (int m = 0; m < track.Length; m++)
                {
                    Console.WriteLine("Массив №{0} ", m + 1);

                    for (int i = 0; i < track[m].Length; i++)
                        Console.Write("\t\t " + track[m][i]);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message + "TEST {0} ERROR",number);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "TEST {0} ERROR", number);
                throw new ArgumentNullException("parameter is null.", e);
            }
            finally
            {
                Console.WriteLine("Результат- " + Level1.Unmanned(L, N, track));
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test2()
        {
            int number = 2;

            int L = 10;
            int N = 1;
            int[][] track = new int[1][];
            track[0] = new[] { 3, 5, 5 };
            //track[0] = new[] { 5, 2, 2 };

            try
            {
                Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
                Console.WriteLine("ОПисание дороги ");
                for (int m = 0; m < track.Length; m++)
                {
                    Console.WriteLine("Массив №{0} ", m + 1);

                    for (int i = 0; i < track[m].Length; i++)
                        Console.Write("\t\t " + track[m][i]);
                    Console.WriteLine();
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
                Console.WriteLine("Результат- " + Level1.Unmanned(L, N, track));
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test3()
        {
            int number = 3;

            int L = 10;
            int N = 1;
            int[][] track = new int[1][];
            //track[0] = new[] { 3, 5, 5 };
            track[0] = new[] { 5, 2, 2 };

            try
            {
                Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
                Console.WriteLine("ОПисание дороги ");
                for (int m = 0; m < track.Length; m++)
                {
                    Console.WriteLine("Массив №{0} ", m + 1);

                    for (int i = 0; i < track[m].Length; i++)
                        Console.Write("\t\t " + track[m][i]);
                    Console.WriteLine();
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
                Console.WriteLine("Результат- " + Level1.Unmanned(L, N, track));
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test4()
        {
            int number = 4;

            int L = 10;
            int N = 2;
            int[][] track = new int[2][];
            track[0] = new[] { 11, 5, 5 };
            track[1] = new[] { 15, 2, 2 };

            try
            {
                Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
                Console.WriteLine("ОПисание дороги ");
                for (int m = 0; m < track.Length; m++)
                {
                    Console.WriteLine("Массив №{0} ", m + 1);

                    for (int i = 0; i < track[m].Length; i++)
                        Console.Write("\t\t " + track[m][i]);
                    Console.WriteLine();
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
                Console.WriteLine("Результат- " + Level1.Unmanned(L, N, track));
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test5()
        {
            int number = 5;

            int L = 10;
            int N = 2;
            int[][] track = new int[2][];
            track[0] = new[] { 10, 5, 5 };
            track[1] = new[] { 15, 2, 2 };

            try
            {
                Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
                Console.WriteLine("ОПисание дороги ");
                for (int m = 0; m < track.Length; m++)
                {
                    Console.WriteLine("Массив №{0} ", m + 1);

                    for (int i = 0; i < track[m].Length; i++)
                        Console.Write("\t\t " + track[m][i]);
                    Console.WriteLine();
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
                Console.WriteLine("Результат- " + Level1.Unmanned(L, N, track));
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test6()
        {
            int number = 6;

            int L = 10;
            int N = 2;
            int[][] track = new int[2][];
            track[0] = new[] { 9, 5, 5 };
            track[1] = new[] { 14, 2, 2 };

            try
            {
                Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
                Console.WriteLine("ОПисание дороги ");
                for (int m = 0; m < track.Length; m++)
                {
                    Console.WriteLine("Массив №{0} ", m + 1);

                    for (int i = 0; i < track[m].Length; i++)
                        Console.Write("\t\t " + track[m][i]);
                    Console.WriteLine();
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
                Console.WriteLine("Результат- " + Level1.Unmanned(L, N, track));
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test7()
        {
            int number = 7;

            int L = 10;
            int N = 2;
            int[][] track = new int[2][];
            track[0] = new[] { 9, 4, 3 };
            track[1] = new[] { 14, 2, 2 };

            try
            {
                Console.WriteLine("Длина дороги {0}; Кол-во светофоров {1} ", L, N);
                Console.WriteLine("ОПисание дороги ");
                for (int m = 0; m < track.Length; m++)
                {
                    Console.WriteLine("Массив №{0} ", m + 1);

                    for (int i = 0; i < track[m].Length; i++)
                        Console.Write("\t\t " + track[m][i]);
                    Console.WriteLine();
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
                Console.WriteLine("Результат- " + Level1.Unmanned(L, N, track));
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
    }
        #endregion
}
