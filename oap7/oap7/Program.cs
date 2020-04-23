using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap7
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ThreeDimensionalArray tda = new ThreeDimensionalArray();
            int[,,] arr1 = tda.GenerationArray(); //Генерация первого массива
            int[,,] arr2 = tda.GenerationArray(); //Генерация второго массива
            int[,,] resArr; //Массив с резульатат

            Console.WriteLine("------------------------------------------------------------------------------");
            tda.WriteArray(arr1);
            Console.WriteLine("------------------------------------------------------------------------------");
            tda.WriteArray(arr2);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Напиши число какое действие сделать с двумя рандомными массивами\n1) Сложить массивы\n2) Вычесть массивы\n3) Умножить массивы на число\n4) Опрелелить сумма какого массива больше");
            int value = Convert.ToInt16(Console.ReadLine());
            switch (value)
            {
                case 1:
                    resArr = tda.SumArray(arr1, arr2);
                    tda.WriteArray(resArr);
                    break;
                case 2:
                    Console.WriteLine("Введите число из какого массива вычитать другой массив\n 1) 1 - 2\n 2) 2 - 1");
                    value = Convert.ToInt16(Console.ReadLine());
                    if (value == 1)
                    {
                        resArr = tda.DifferenceArrays(arr1, arr2);
                        tda.WriteArray(resArr);
                    }
                    else if (value == 2)
                    {
                        resArr = tda.DifferenceArrays(arr2, arr1);
                        tda.WriteArray(resArr);
                    }
                    else
                    {
                        Console.WriteLine("Не выбрана цифра");
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите массив который будет умножатся на число\n 1) 1 \n 2) 2 ");
                    value = Convert.ToInt16(Console.ReadLine());
                    if (value == 1)
                    {
                        Console.WriteLine("Введите число для умножения");
                        int num = Convert.ToInt16(Console.ReadLine());
                        resArr = tda.MultiplicationArray(arr1, num);
                        tda.WriteArray(resArr);
                    }
                    else if (value == 2)
                    {
                        Console.WriteLine("Введите число для умножения");
                        int num = Convert.ToInt16(Console.ReadLine());
                        resArr = tda.MultiplicationArray(arr2, num);
                        tda.WriteArray(resArr);
                    }
                    else
                    {
                         Console.WriteLine("Не выбрана цифра");
                    }
                    break;
                case 4:
                    int res1 = tda.ComparisonArrays(arr1);
                    int res2 = tda.ComparisonArrays(arr2);
                    if (res1 > res2) Console.WriteLine($"Сумма первого массива больше {res1} > {res2}");
                    else if (res2 < res1) Console.WriteLine($"Сумма второго массива больше {res2} < {res1}");
                     else if (res1 == res2) Console.WriteLine($"Сумма массивов равна {res1} = {res2}");
                    else Console.WriteLine("Ошибка!");
                    break;
                default:
                    Console.WriteLine("Вы ввели число не от 1 до 4!");
                    break;
            }
            Console.ReadLine();
        }
    }
}