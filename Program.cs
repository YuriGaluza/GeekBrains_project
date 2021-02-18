using System;
using Level_1.Lesson_1;
using Level_1.Lesson_2;
using Level_1.Lesson_3;
using Level_1.Lesson_4;

namespace Level_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1 task1 = new Task1();
            //task1.HelloUser();
            
            // Task2 task2 = new Task2();
            // double averageDailyTemperature = task2.AverageDailyTemperature();
            // int monthByNumber = task2.GetMonthByNumber();
            // task2.IsEven();
            // task2.ShowPayCheck();
            // task2.RainyWinter(averageDailyTemperature, monthByNumber);

            // Task3 task3 = new Task3();
            // task3.DiagonalElementsOfArray(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
            // task3.GetPhoneBook();
            // task3.ReverseString("Hello");
            // task3.BattleShip();

            Task4 task4 = new Task4();
            task4.GetFullName("Путин", "Владимир", "Владимирович");
            task4.GetFullName("Келдыш", "Мстислав", "Всеволодович");
            task4.GetFullName("Крамник", "Владимир", "Борисович");
            task4.SumOfNumbersFromString("1 2 3 4");
            task4.GetSeasonByMonthNumber();
            task4.ShowFibonacciNumber();
        }
    }
}
