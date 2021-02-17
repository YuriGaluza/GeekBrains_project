using System;

namespace Level_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 Task1 = new Task1();
            //Task1.HelloUser();

            //Task2 Task2 = new Task2();
            //double averageDailyTemperature = Task2.AverageDailyTemperature();
            //int monthByNumber = Task2.GetMonthByNumber();
            //Task2.IsEven();
            //Task2.ShowPayCheck();
            //Task2.RainyWinter(averageDailyTemperature, monthByNumber);

            Task3 task3 = new Task3();
            task3.DiagonalElementsOfArray(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
            task3.GetPhoneBook();
            task3.ReverseString("Hello");
            task3.BattleShip();
        }
    }
}
