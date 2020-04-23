using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap7
{
    public class ThreeDimensionalArray
    {
        Random ran = new Random(); //Объект для генерации случайных числел
        protected const int minArray = 0; //Минимальное число для генерации случайных числел
        protected const int maxArray = 255; //Максимальное число для генерации случайных числел

        //Вывод массивива на экран
        public void WriteArray(int[,,] mass)
        {

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    for (int k = 0; k < mass.GetLength(2); k++)
                    {
                        Console.Write(String.Format("{0,5}", mass[i, j, k]));
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        //Генерация случайного массива
        public int[,,] GenerationArray()
        {
            int[,,] arrayResult = new int[5, 5, 5];

            // Инициализируем данный массив

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arrayResult[i, j, k] = ran.Next(ThreeDimensionalArray.minArray, ThreeDimensionalArray.maxArray);
                    }
                }
            }
            return arrayResult;
        }

        //Сложение массивов
        public int[,,] SumArray(int[,,] mass1, int[,,] mass2)
        {
            int[,,] arrayResult = new int[5, 5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arrayResult[i, j, k] = mass1[i, j, k] + mass2[i, j, k];
                    }
                }
            }
            return arrayResult;
        }

        //Вычитание массивов
        public int[,,] DifferenceArrays(int[,,] mass1, int[,,] mass2)
        {
            int[,,] arrayResult = new int[5, 5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arrayResult[i, j, k] = mass1[i, j, k] - mass2[i, j, k];
                    }
                }
            }
            return arrayResult;
        }

        //Умножение массива
        public int[,,] MultiplicationArray(int[,,] mass1, int num)
        {
            int[,,] arrayResult = new int[5, 5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arrayResult[i, j, k] = mass1[i, j, k] * num;
                    }
                }
            }
            return arrayResult;
        }

        //Нахождение суммы массива
        public int ComparisonArrays(int[,,] mass1)
        {
            int mass_1 = 0; //Сумма массива

            for (int i = 0; i < mass1.GetLength(0); i++)
            {
                for (int j = 0; j < mass1.GetLength(1); j++)
                {
                    for (int k = 0; k < mass1.GetLength(2); k++)
                    {
                        mass_1 += mass1[i, j, k];
                    }
                }
            }
            return mass_1;
        }
    }
}