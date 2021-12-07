using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания "Мастер ключей"
    /// </summary>
    [TestClass]
    public class Football
    {
        [TestMethod]
        [TestCategory("28 задач")]
        
        public void Football1()
        {
            int k = 3;

            try
            {
                Level1.Keymaker(k);
                Assert.IsTrue(Level1.Keymaker(k));
            }
            catch (Exception)
            {
                Assert.Fail("TRUE");
            }
            finally
            {
                Console.WriteLine("результат: " + Level1.Keymaker(k));
            }
        }
        
    }
}