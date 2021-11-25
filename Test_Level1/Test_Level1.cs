﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Level1Space;

namespace Test_Level1
{
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    ///<summary> 
    ///Тесты для задания №22 "Чубакка и гравитационные колодцы"
    /// </summary>
    [TestClass]
    public class Test_Level1
    {
        [TestMethod]
        [TestCategory("tests")]
        public void Test1()
        {
            int number = 1;

            int[] A = { 1, 2, 1, 7, 2, 4, 3, 1, 5, 1, 2, 1, 6, 1, 2 }; //50233
            int N = 15;

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
        public void Test2()
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
        public void Test3()
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
        public void Test4()
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