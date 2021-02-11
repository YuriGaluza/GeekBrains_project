using System;

namespace Level_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 Task1 = new Task1();
            Task1.HelloUser();

            Task2 Task2 = new Task2();
            double averageDailyTemperature = Task2.AverageDailyTemperature();
            int monthByNumber = Task2.GetMonthByNumber();
            Task2.IsEven();
            Task2.RainyWinter(averageDailyTemperature, monthByNumber);
        }
    }
}
