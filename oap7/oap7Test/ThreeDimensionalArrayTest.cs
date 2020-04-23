using System;
using oap7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace oap7Test
{
    [TestClass]
    public class ThreeDimensionalArrayTest
    {
        //Проверка на успешное создание массива случайных числел
        [TestMethod]
        public void TestGenerationArray()
        {
            var expected = false;
            ThreeDimensionalArray tda = new ThreeDimensionalArray();

            var actual = tda.GenerationArray();

            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    for (int k = 0; k < actual.GetLength(2); k++)
                    {
                        expected = true;
                    }
                }
            }
            Assert.IsTrue(expected);
        }

        //Проверка на правильность сложения массивов случайных числел
        [TestMethod]
        public void TestSumArrays()
        {
            ThreeDimensionalArray tda = new ThreeDimensionalArray();
            //Первый массив
            int[,,] mass1 = tda.GenerationArray();
            //Второй массив
            int[,,] mass2 = tda.GenerationArray();
            //Резульатат сложения
            var expected = false;
            int[,,] actual = tda.SumArray(mass1, mass2);

            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    for (int k = 0; k < actual.GetLength(2); k++)
                    {
                        if (actual[i, j, k] == mass1[i, j, k] + mass2[i, j, k])
                        {
                            expected = true;
                        }
                    }
                }
            }

            Assert.IsTrue(expected);
        }

        //Проверка на правильность умножения массива случайных числел на число
        [TestMethod]
        public void TestMultiplicationArrays()
        {
            ThreeDimensionalArray tda = new ThreeDimensionalArray();
            var num = 3;
            int[,,] mass1 = tda.GenerationArray();

            var expected = false;

            int[,,] actual = tda.MultiplicationArray(mass1, num);

            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    for (int k = 0; k < actual.GetLength(2); k++)
                    {
                        if (actual[i, j, k] == mass1[i, j, k] * num)
                        {
                            expected = true;
                        }
                    }
                }
            }
            Assert.IsTrue(expected);
        }
        //Проверка на правильность вычитания массивов случайных чисел
        [TestMethod]
        public void TestDifferenceArrays()
        {
            ThreeDimensionalArray tda = new ThreeDimensionalArray();

            var expected = false;

            int[,,] mass1 = tda.GenerationArray();
            int[,,] mass2 = tda.GenerationArray();

            int[,,] actual = tda.DifferenceArrays(mass1, mass2);

            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    for (int k = 0; k < actual.GetLength(2); k++)
                    {
                        if (actual[i, j, k] == mass1[i, j, k] - mass2[i, j, k])
                        {
                            expected = true;
                        }
                    }
                }
            }
            Assert.IsTrue(expected);

        }

        //Проверка на правильность выявления какой массив больше
        [TestMethod]
        public void TestComparisonArrays()
        {
            ThreeDimensionalArray tda = new ThreeDimensionalArray();
            var sum = 0;

            int[,,] mass1 = tda.GenerationArray();

            var actual = tda.ComparisonArrays(mass1);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        sum += mass1[i, j, k];
                    }
                }
            }
            Assert.AreEqual(sum, actual);

        }
    }
}
