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
    public class Hodoki
    {
        [TestMethod]
        [TestCategory("28 задач")]
        
        public void Hodoki1()
        {
            string village = "axxb6===4xaf5===eee5";

            try
            {
                Level1.white_walkers(village);
                Assert.IsTrue(Level1.white_walkers(village));
            }
            catch (Exception)
            {
                Assert.Fail("TRUE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.white_walkers(village));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Hodoki2()
        {
            string village = "5==ooooooo=5=5";

            try
            {
                Level1.white_walkers(village);
                Assert.IsTrue(!Level1.white_walkers(village));
            }
            catch (Exception)
            {
                Assert.Fail("FALSE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.white_walkers(village));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Hodoki3()
        {
            string village = "abc=7==hdjs=3gg1=======5";

            try
            {
                Level1.white_walkers(village);
                Assert.IsTrue(Level1.white_walkers(village));
            }
            catch (Exception)
            {
                Assert.Fail("TRUE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.white_walkers(village));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Hodoki4()
        {
            string village = "aaS=8";

            try
            {
                Level1.white_walkers(village);
                Assert.IsFalse(Level1.white_walkers(village));
            }
            catch (Exception)
            {
                Assert.Fail("FALSE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.white_walkers(village));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Hodoki5()
        {
            string village = "9===1===9===1===9";

            try
            {
                Level1.white_walkers(village);
                Assert.IsTrue(Level1.white_walkers(village));
            }
            catch (Exception)
            {
                Assert.Fail("TRUE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.white_walkers(village));
            }
        }
        [TestMethod]
        [TestCategory("28 задач")]

        public void Hodoki6()
        {
            string village = "9191919191";

            try
            {
                Level1.white_walkers(village);
                Assert.IsFalse(Level1.white_walkers(village));
            }
            catch (Exception)
            {
                Assert.Fail("False");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.white_walkers(village));
            }
        }
    }
}