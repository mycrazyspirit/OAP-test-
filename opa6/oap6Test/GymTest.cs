using System;
using opa6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oap6;

namespace opa6
{
    [TestClass]
    public class GymTest
    {
        //Проверка геттера и сеттера
        [TestMethod]
        public void TestGetterAndSetter()
        {
            // arrange
            var age = 14; //Первый возраст
            var expected = 14;
            Gym gym = new Gym(age); //Добавление первого возраста

            // act
            int actual = gym.Age; //Получение возраста
            // assert
            Assert.AreEqual(expected, actual); // Сравнение
        }

        //Проверка выбрасывания ошибки при неправильном возрасте
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Age is out of range")]
        public void TestGetterAndSetterThrows()
        {
            int age = 71;
            Gym gym = new Gym(age);

        }
        //Проверка подчетов класс
        [TestMethod]
        public void TestGymClass()
        {
            // arrange
            int age1 = 20;
            int age2 = 25;

            Gym gym = new Gym(age1);
            gym = new Gym(age2);

            var expected = 14; //Минимальный возраст ответ
            var expected1 = 25; //Максимальный возраст ответ
            var expected2 = 19.7; //Средний возраст ответ
            // act
            gym.Main();
            var actual = gym.MinAgeClient; //Минимальный возраст подчет
            var actual1 = gym.MaxAgeClient; //Максимальный возраст подчет
            var actual2 = gym.AvgAgeClient; //Средний возраст подчет
            // assert
            Assert.AreEqual(expected, actual); // Сравнение
            Assert.AreEqual(expected1, actual1); // Сравнение
            Assert.AreEqual(expected2, actual2); // Сравнение
        }

    }
}
