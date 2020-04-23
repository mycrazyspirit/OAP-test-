using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int age;
            int minAge = 0;
            int maxAge = 0;
            double avgAge = 0.00;
            Console.WriteLine("Введите кол-во клиентов посетивших зал:");
            count = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите возраст клиентов");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите возраст {i + 1}-го клиента:");
                age = Convert.ToInt16(Console.ReadLine());
                Gym gym = new Gym(age);
                minAge = gym.MinAgeClient;
                maxAge = gym.MaxAgeClient;
                avgAge = gym.AvgAgeClient;
            }

            Console.WriteLine($"\nМинимальный возраст: {minAge}\nМаксимальный возраст: {maxAge}\nСредний возраст: {avgAge}\n");
            Console.ReadLine();
        }
    }
}
