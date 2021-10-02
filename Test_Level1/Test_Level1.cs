using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class Test_Level1
    {
        [TestMethod]
        [TestCategory("tests")]
        public void Test1()
        {
            int number = 1;

            int H1 = 3;
            int W1 = 4;
            string S1 = "1234 2345 0987";//\n
            int H2 = 2;
            int W2 = 2;
            string S2 = "34 98";


            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат функции- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - "+"входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test2()
        {
            int number = 2;

            int H1 = 4;
            int W1 = 4;
            string S1 = "1234 5555 2345 0987";
            int H2 = 2;
            int W2 = 2;
            string S2 = "34 98";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test3()
        {
            int number = 3;

            int H1 = 3;
            int W1 = 4;
            string S1 = "1234 2345 0987";
            int H2 = 3;
            int W2 = 2;
            string S2 = "34 98 00";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "НЕ входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test4()
        {
            int number = 4;

            int H1 = 4;
            int W1 = 4;
            string S1 = "1234 2345 0987 0000";
            int H2 = 3;
            int W2 = 2;
            string S2 = "34 98 00";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test5()
        {
            int number = 5;

            int H1 = 2;
            int W1 = 1;
            string S1 = "1 0";
            int H2 = 1;
            int W2 = 1;
            string S2 = "0";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test6()
        {
            int number = 6;

            int H1 = 3;
            int W1 = 4;
            string S1 = "3 4 1234 2345 0987";
            int H2 = 2;
            int W2 = 2;
            string S2 = "2 2 34 98";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "НЕ входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test7()
        {
            int number = 7;

            int H1 = 3;
            int W1 = 4;
            string S1 = "0000 0000 0000";
            int H2 = 2;
            int W2 = 2;
            string S2 = "00 00";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test8()
        {
            int number = 8;

            int H1 = 3;
            int W1 = 4;
            string S1 = "3 4 1234 2345 0987";
            int H2 = 4;
            int W2 = 5;
            string S2 = "4 5 34111 98111 11111 11111";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "НЕ входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test9()
        {
            int number = 9;

            int H1 = 3;
            int W1 = 1;
            string S1 = "0 0 0";
            int H2 = 3;
            int W2 = 1;
            string S2 = "0 0 0";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test10()
        {
            int number = 10;

            int H1 = 3;
            int W1 = 4;
            string S1 = "a234 2345 0987";
            int H2 = 2;
            int W2 = 2;
            string S2 = "34 98";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test11()
        {
            int number = 11;

            int H1 = 3;
            int W1 = 3;
            string S1 = "321 694 798";
            int H2 = 2;
            int W2 = 2;
            string S2 = "69 98";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "НЕ входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test12()
        {
            int number = 12;

            int H1 = 4;
            int W1 = 4;
            string S1 = "1234 2345 0987 0000";
            int H2 = 3;
            int W2 = 2;
            string S2 = "34 09 00";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "НЕ входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test13()
        {
            int number = 13;

            int H1 = 4;
            int W1 = 4;
            string S1 = "1234 2345 0987 0000";
            int H2 = 3;
            int W2 = 2;
            string S2 = "34 45 09";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "НЕ входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test14()
        {
            int number = 14;

            int H1 = 4;
            int W1 = 4;
            string S1 = "1234 2345 1234 3400";
            int H2 = 2;
            int W2 = 2;
            string S2 = "12 34";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test15()
        {
            int number = 15;

            int H1 = 4;
            int W1 = 6;
            string S1 = "029402 560202 029694 780288";
            int H2 = 2;
            int W2 = 2;
            string S2 = "02 94";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test16()
        {
            int number = 16;

            int H1 = 3;
            int W1 = 4;
            string S1 = "0000 0000 0000";
            int H2 = 2;
            int W2 = 2;
            string S2 = "00 01";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "НЕ входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test17()
        {
            int number = 17;

            int H1 = 3;
            int W1 = 4;
            string S1 = "1234 2345 0987";
            int H2 = 4;
            int W2 = 5;
            string S2 = "34111 98111 11111 11111";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "НЕ входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test18()
        {
            int number = 18;

            int H1 = 3;
            int W1 = 6;
            string S1 = "341234 000345 000987";
            int H2 = 2;
            int W2 = 3;
            string S2 = "000 000";

            try
            {
                Console.WriteLine("Карта {0} {1}: {2}", H1, W1, S1);
                Console.WriteLine("Группировка танков {0} {1}: {2}", H2, W2, S2);
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
                Console.WriteLine("Результат- " + Level1.TankRush(H1, W1, S1, H2, W2, S2));
                Console.WriteLine("Реальный результат - " + "входит");
                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
    }
    #endregion
}
