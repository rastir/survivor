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
    }
}