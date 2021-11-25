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
    public class Chubakka
    {
        [TestMethod]
        [TestCategory("28 задач")]
        
        public void Chubakka1()
        {
            int[] A = { 1, 2, 1, 7, 2, 4, 3, 1, 5, 1, 2, 1, 6, 1, 2 }; //50233
            int N = 15;

            try
            {
                //Level1.TransformTransform(A, N);
                Assert.IsTrue(Level1.TransformTransform2(A, N) == 50233);
            }
            catch (Exception e)
            {
                Assert.Fail("Не равно 50233 ");
            }
            finally
            {
                Console.WriteLine("результат:");
                Console.WriteLine(" " + Level1.TransformTransform(A, N));
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Chubakka2()
        {
            int number = 2;

            int[] A = { 1 }; 
            int N = 1;

            try
            {
                Level1.TransformTransform(A, N);
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
                Console.WriteLine("результат:");
                Console.WriteLine(" " + Level1.TransformTransform(A, N));
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Chubakka3()
        {
            int number = 3;

            int[] A = { 1, 1, 1, 1, 1, 1, 1 };
            int N = 7;

            try
            {
                Level1.TransformTransform(A, N);
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
                Console.WriteLine("результат:");
                Console.WriteLine(" " + Level1.TransformTransform(A, N));
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Chubakka4()
        {
            int number = 4;

            int[] A = { 1, 5, 9, 9, 1, 1, 1, 3, 1, 5, 9, 9, 1, 1, 1, 3 };
            int N = 16;

            try
            {
                Level1.TransformTransform(A, N);
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
                Console.WriteLine("результат:");
                Console.WriteLine(" " + Level1.TransformTransform(A, N));
            }
        }
    }
}