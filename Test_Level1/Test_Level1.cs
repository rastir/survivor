using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №22 "Древо Жизни Андрассил"
    /// </summary>
    [TestClass]
    public class Test_Level1
    {
        [TestMethod]
        [TestCategory("tests")]
        public void Test1()
        {
            int number = 1;

            string[] Matrix = { "123456", "234567", "345678", "456789" };
            int M = 4;
            int N = 6;
            int T = 3;

            try
            {
                Level1.MatrixTurn(Matrix, M, N, T);
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
                for (int i = 0; i < Matrix.Length; i++)
                {
                    Console.WriteLine(" " + Matrix[i]);
                }

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
        [TestMethod]
        [TestCategory("tests")]
        public void Test2()
        {
            int number = 2;

            string[] Matrix = { "123456", "234567", "345678", "456789" };
            int M = 4;
            int N = 6;
            int T = 9;

            try
            {
                Level1.MatrixTurn(Matrix, M, N, T);
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
                for (int i = 0; i < Matrix.Length; i++)
                {
                    Console.WriteLine(" " + Matrix[i]);
                }

                Console.WriteLine("TEST {0} PASSED", number);
            }
        }
    }
}