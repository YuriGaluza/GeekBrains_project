using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1
{
    class Task2
    {
        public double AverageDailyTemperature()
        {
            //1.	Запросить у пользователя минимальную и максимальную температуру за сутки
            //и вывести среднесуточную температуру
            Console.Write("Введите минимальную суточную температуру: ");
            int minTemperature = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную суточную температуру: ");
            int maxTemperature = Convert.ToInt32(Console.ReadLine());
            double averageTemperature = 0.5 * (minTemperature + maxTemperature);


            if (maxTemperature > minTemperature)
            {
                Console.WriteLine($"Среднесуточная температура равна {averageTemperature}");
            }
            else if (maxTemperature < minTemperature)
            {
                Console.WriteLine($"Минимальная температура должна быть иеньше максимальной ");
            }
            return averageTemperature;
        }

        //2.	Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        public int GetMonthByNumber()
        {
            Console.Write("Введите порядковый номер месяца: ");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());

            if (numberOfMonth > 12 && numberOfMonth < 0)
            {
                Console.WriteLine($"Номер месяц должен быть больше 0 и меньше 13");
            }
            else
            {
                Console.WriteLine($"Месяц по номеру {numberOfMonth} является " + (Months)numberOfMonth);
            }
            return numberOfMonth;
        }

        //3.	Определить, является ли введённое пользователем число чётным.
        public void IsEven()
        {
            Console.Write("Введите любое натуральное число: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value % 2 == 0)
            {
                Console.WriteLine($"Число {value} чётное");
            }
            else
            {
                Console.WriteLine($"Число {value} нечётное");
            }
        }

        //4.	(*) Если пользователь указал месяц из зимнего периода,
        //а средняя температура > 0, вывести сообщение «Дождливая зима».
        public void RainyWinter(double averageTemperature, int numberOfMonth)
        {
            if (numberOfMonth == 1 || numberOfMonth == 2 || numberOfMonth == 12 && averageTemperature > 0)
                Console.WriteLine("Дождливая зима");
            else
            {
                Console.WriteLine($"Месяц {(Months)numberOfMonth}, среднесуточная температура {averageTemperature}");
            }
        }
        

        public enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
