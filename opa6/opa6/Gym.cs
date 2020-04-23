using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap6
{
    public class Gym
    {
        static List<int> ages = new List<int> { };
        protected int age; // Возраст посетителя
        protected int count; //Кол-во поситителей
        protected const int MIN_AGE = 14; //Минимальный возраст поситителя
        protected const int MAX_AGE = 70; //Максимальный возраст поситителя
        protected int minAgeClient = 0; //Минимальный возраст поситителя
        protected int maxAgeClient = 0; //Максимальный возраст поситителя
        protected int sumAges; //Сумма возростов
        protected double avgAgeClient = 0.0; //Средний возраст поситителей


        public Gym(int ages) //Конструктор
        {
            this.Age = ages;
            this.AddAge();
            this.Main();
        }

        public int Age //Геттер и Сеттер для age
        {
            set
            {
                if (value >= Gym.MIN_AGE && value <= Gym.MAX_AGE) //Проверка введеного возраста;
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age is out of range");
                }
            }
            get { return age; }
        }

        protected void AddAge() //Добавление возраста в List
        {
            Gym.ages.Add(this.Age);
        }

        public int MinAgeClient { get { return minAgeClient; } set { minAgeClient = value; } } //Геттер и Сеттре для минимального возраста клиента
        public int MaxAgeClient { get { return maxAgeClient; } set { maxAgeClient = value; } } //Геттер и сеттер для максимального возраста клиента
        public double AvgAgeClient { get { return avgAgeClient; } set { avgAgeClient = value; } } //Геттер и сеттер для среднего возраста клиентов

        public void Main() // Произведение всех расчетов
        {
            this.CalculateMaxAge(Gym.ages);
            this.CalculateMinAge(Gym.ages);
            int sumAges = this.CalculateSumAge(Gym.ages);
            int count = this.FindCountAges(Gym.ages);
            this.CalculateAvgAge(sumAges, count);
        }

        protected int FindCountAges(List<int> age) //Вычисление количества возростов
        {
            this.count = age.Count();
            return this.count;
        }

        protected void CalculateMaxAge(List<int> age) //Нахождение максимального возраста
        {
            this.MaxAgeClient = age.Max();
        }
        protected void CalculateMinAge(List<int> age) //Нахождние минимального возраста
        {
            this.MinAgeClient = age.Min();
        }
        protected int CalculateSumAge(List<int> age) //Нахождение суммы возростов
        {
            this.sumAges = age.Sum();
            return this.sumAges;
        }
        protected void CalculateAvgAge(int sumAges, int count) //Нахождение среднего возраста
        {
            double avg = Math.Round(((double)sumAges / count), 1);
            this.AvgAgeClient = avg;
        }
    }
}
