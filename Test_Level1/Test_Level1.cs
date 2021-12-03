using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №22 "Чубакка и гравитационные колодцы"
    /// </summary>
    [TestClass]
    public class Football
    {
        [TestMethod]
        [TestCategory("28 задач")]
        
        public void Football1()
        {
            int[] F = { 1, 3, 2 };
            int N = 3;

            try
            {
                Level1.Football(F, N);
                Assert.IsTrue(Level1.Football(F, N));
            }
            catch (Exception)
            {
                Assert.Fail("TRUE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.Football(F, N));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Football2()
        {
            int[] F = { 3, 2, 1 };
            int N = 3;

            try
            {
                Level1.Football(F, N);
                Assert.IsTrue(Level1.Football(F, N));
            }
            catch (Exception)
            {
                Assert.Fail("TRUE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.Football(F, N));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Football3()
        {
            int[] F = { 1, 7, 5, 3, 9 };
            int N = 5;

            try
            {
                Level1.Football(F, N);
                Assert.IsTrue(Level1.Football(F, N));
            }
            catch (Exception)
            {
                Assert.Fail("TRUE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.Football(F, N));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Football4()
        {
            int[] F = { 9, 5, 3, 7, 1 };
            int N = 5;

            try
            {
                Level1.Football(F, N);
                Assert.IsFalse(Level1.Football(F, N));
            }
            catch (Exception)
            {
                Assert.Fail("False");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.Football(F, N));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Football5()
        {
            int[] F = { 1, 4, 3, 2, 5 };
            int N = 5;

            try
            {
                Level1.Football(F, N);
                Assert.IsTrue(Level1.Football(F, N));
            }
            catch (Exception)
            {
                Assert.Fail("TRUE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.Football(F, N));
            }
        }
    }
}