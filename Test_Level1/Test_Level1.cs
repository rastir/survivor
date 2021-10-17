﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    /// <summary>
    /// Тесты для задания №6 Level1 "Курс 28 заданий"
    /// </summary>
    [TestClass]
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №15 "Танковый раш"
    /// </summary>
    #region
    //public class Test_Level1
    //{
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test1()
    //    {
    //        int number = 1;

    //        int H1 = 3;
    //        int W1 = 4;
    //        string S1 = "1234 2345 0987";//\n
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "34 98";


    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - "+"входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test2()
    //    {
    //        int number = 2;

    //        int H1 = 4;
    //        int W1 = 4;
    //        string S1 = "1234 5555 2345 0987";
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "34 98";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test3()
    //    {
    //        int number = 3;

    //        int H1 = 3;
    //        int W1 = 4;
    //        string S1 = "1234 2345 0987";
    //        int H2 = 3;
    //        int W2 = 2;
    //        string S2 = "34 98 00";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test4()
    //    {
    //        int number = 4;

    //        int H1 = 4;
    //        int W1 = 4;
    //        string S1 = "1234 2345 0987 0000";
    //        int H2 = 3;
    //        int W2 = 2;
    //        string S2 = "34 98 00";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test5()
    //    {
    //        int number = 5;

    //        int H1 = 2;
    //        int W1 = 1;
    //        string S1 = "1 0";
    //        int H2 = 1;
    //        int W2 = 1;
    //        string S2 = "0";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test6()
    //    {
    //        int number = 6;

    //        int H1 = 3;
    //        int W1 = 4;
    //        string S1 = "3 4 1234 2345 0987";
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "2 2 34 98";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test7()
    //    {
    //        int number = 7;

    //        int H1 = 3;
    //        int W1 = 4;
    //        string S1 = "0000 0000 0000";
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "00 00";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test8()
    //    {
    //        int number = 8;

    //        int H1 = 3;
    //        int W1 = 4;
    //        string S1 = "3 4 1234 2345 0987";
    //        int H2 = 4;
    //        int W2 = 5;
    //        string S2 = "4 5 34111 98111 11111 11111";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test9()
    //    {
    //        int number = 9;

    //        int H1 = 3;
    //        int W1 = 1;
    //        string S1 = "0 0 0";
    //        int H2 = 3;
    //        int W2 = 1;
    //        string S2 = "0 0 0";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test10()
    //    {
    //        int number = 10;

    //        int H1 = 3;
    //        int W1 = 4;
    //        string S1 = "a234 2345 0987";
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "34 98";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test11()
    //    {
    //        int number = 11;

    //        int H1 = 3;
    //        int W1 = 3;
    //        string S1 = "321 694 798";
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "69 98";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test12()
    //    {
    //        int number = 12;

    //        int H1 = 4;
    //        int W1 = 4;
    //        string S1 = "1234 2345 0987 0000";
    //        int H2 = 3;
    //        int W2 = 2;
    //        string S2 = "34 09 00";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test13()
    //    {
    //        int number = 13;

    //        int H1 = 4;
    //        int W1 = 4;
    //        string S1 = "1234 2345 0987 0000";
    //        int H2 = 3;
    //        int W2 = 2;
    //        string S2 = "34 45 09";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test14()
    //    {
    //        int number = 14;

    //        int H1 = 4;
    //        int W1 = 4;
    //        string S1 = "1234 2345 1234 3400";
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "12 34";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test15()
    //    {
    //        int number = 15;

    //        int H1 = 4;
    //        int W1 = 6;
    //        string S1 = "029402 560202 029694 780288";
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "02 94";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test16()
    //    {
    //        int number = 16;

    //        int H1 = 3;
    //        int W1 = 4;
    //        string S1 = "0000 0000 0000";
    //        int H2 = 2;
    //        int W2 = 2;
    //        string S2 = "00 01";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test17()
    //    {
    //        int number = 17;

    //        int H1 = 3;
    //        int W1 = 4;
    //        string S1 = "1234 2345 0987";
    //        int H2 = 4;
    //        int W2 = 5;
    //        string S2 = "34111 98111 11111 11111";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test18()
    //    {
    //        int number = 18;

    //        int H1 = 3;
    //        int W1 = 6;
    //        string S1 = "341234 000345 000987";
    //        int H2 = 2;
    //        int W2 = 3;
    //        string S2 = "000 000";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test19()
    //    {
    //        int number = 19;

    //        int H1 = 1;
    //        int W1 = 1;
    //        string S1 = "1";
    //        int H2 = 1;
    //        int W2 = 1;
    //        string S2 = "1";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test20()
    //    {
    //        int number = 20;

    //        int H1 = 1;
    //        int W1 = 1;
    //        string S1 = "1";
    //        int H2 = 1;
    //        int W2 = 1;
    //        string S2 = "0";

    //        try
    //        {
    //            Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
    //            Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
    //            Console.WriteLine("Реальный результат - " + "НЕ входит");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //}
    #endregion
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №16 "Шопоголики"
    /// </summary>
    #region
    //public class Test_Level1
    //{
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test1()
    //    {
    //        int number = 1;

    //        int N = 7;
    //        int[] Price = { 400, 350, 300, 250, 200, 150, 100 };

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.MaximumDiscount(N, Price));
    //            Console.WriteLine("Реальный результат - " + "450");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test2()
    //    {
    //        int number = 2;

    //        int N = 11;
    //        int[] Price = { 1, 1000, 0, 33, 400, 350, 300, 250, 200, 150, 100 };

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.MaximumDiscount(N, Price));
    //            Console.WriteLine("Реальный результат - " + "583");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test3()
    //    {
    //        int number = 3;

    //        int N = 15;
    //        int[] Price = { 1, 1, 1, 1000, 0, 33, 400, 350, 300, 250, 200, 150, 100, 0, 0 };

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.MaximumDiscount(N, Price));
    //            Console.WriteLine("Реальный результат - " + "584");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test4()
    //    {
    //        int number = 4;

    //        int N = 13;
    //        int[] Price = { 1, 1, 1, 1000, 0, 33, 400, 350, 300, 250, 200, 150, 100 };

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.MaximumDiscount(N, Price));
    //            Console.WriteLine("Реальный результат - " + "584");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test5()
    //    {
    //        int number = 5;

    //        int N = 9;
    //        int[] Price = { 1, 1, 1, 1, 5, 0, 0, 0, 10 };

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.MaximumDiscount(N, Price));
    //            Console.WriteLine("Реальный результат - " + "2");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test6()
    //    {
    //        int number = 6;

    //        int N = 9;
    //        int[] Price = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.MaximumDiscount(N, Price));
    //            Console.WriteLine("Реальный результат - " + "0");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //}
    #endregion
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №17 "Машинное распознавание паттернов"
    /// </summary>
    #region
    //public class Test_Level1
    //{
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test1()
    //    {
    //        int number = 1;
    //        string line = "*..*..*..*..*..*..*";

    //        try
    //        {
    //            Console.WriteLine(line);
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "true");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test2()
    //    {
    //        int number = 2;
    //        string line = "*..*...*..*..*..*..*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test3()
    //    {
    //        int number = 3;
    //        string line = "*..*..*..*..*..**..*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test4()
    //    {
    //        int number = 4;
    //        string line = "*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "true");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test5()
    //    {
    //        int number = 5;
    //        string line = "***";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "true");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test6()
    //    {
    //        int number = 6;
    //        string line = "*.......*.......*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "true");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test7()
    //    {
    //        int number = 7;
    //        string line = "**";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "true");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test8()
    //    {
    //        int number = 8;
    //        string line = "*.*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "true");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test9()
    //    {
    //        int number = 9;
    //        string line = "*..*...*...*...*...*..*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test10()
    //    {
    //        int number = 10;
    //        string line = "*..*.*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test11()
    //    {
    //        int number = 11;
    //        string line = "*..*.";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test12()
    //    {
    //        int number = 12;
    //        string line = "..*..*..*..*..*..*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test13()
    //    {
    //        int number = 13;
    //        string line = "*..*...*";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test14()
    //    {
    //        int number = 14;
    //        string line = ".";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test15()
    //    {
    //        int number = 15;
    //        string line = "..";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test16()
    //    {
    //        int number = 16;
    //        string line = "*.";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test17()
    //    {
    //        int number = 17;
    //        string line = "";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //    [TestMethod]
    //    [TestCategory("tests")]
    //    public void Test18()
    //    {
    //        int number = 18;
    //        string line = " ";

    //        try
    //        {
    //            Console.WriteLine("Кол-во {0}, массив: {1}");
    //            Console.WriteLine();
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
    //        }
    //        catch (NullReferenceException e)
    //        {
    //            Console.WriteLine(e.Message + "TEST {0} ERROR", number);
    //            throw new ArgumentNullException("parameter is null.", e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Результат функции- " + Level1.LineAnalysis(line));
    //            Console.WriteLine("Реальный результат - " + "false");
    //            Console.WriteLine("TEST {0} PASSED", number);
    //        }
    //    }
    //}
    #endregion
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
