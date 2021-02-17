using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1
{
    class Task2
    {
        //1. Запросить у пользователя минимальную и максимальную температуру за сутки
        //и вывести среднесуточную температуру
        public double AverageDailyTemperature()
        {
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
                Console.WriteLine($"Минимальная температура должна быть меньше максимальной ");
            }
            Console.WriteLine();
            return averageTemperature;
        }

        //2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        public int GetMonthByNumber()
        {
            Console.Write("Введите порядковый номер месяца: ");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());

            if (numberOfMonth > 12 || numberOfMonth < 0)
            {
                Console.WriteLine($"Номер месяц должен быть больше 0 и меньше 13");
            }
            else
            {
                Console.WriteLine($"Месяц по номеру {numberOfMonth} является " + (Months)numberOfMonth);
            }
            Console.WriteLine();
            return numberOfMonth;
        }

        //3. Определить, является ли введённое пользователем число чётным.
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
            Console.WriteLine();
        }

        //4. Для полного закрепления понимания простых типов найдите любой чек,
        //либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
        //только за место динамических, по вашему мнению,
        //данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные,
        //которые были заранее заготовлены до вывода на консоль.
        public void ShowPayCheck()
        {
            int payCheckNumber = 1245565;
            string product1_name = "Сахар песок фас. 1кг";
            double product1_cost = 85.36;
            int product1_quantity = 3;
            string product2_name = "ГОСТ Молоко питьевое паст";
            double product2_cost = 35.34;
            int product2_quantity = 2;

            string message = $"Магнит\nЗАО Тандер\nЧек №{payCheckNumber} \n" +
                $"ЧЕК НА ПРОДАЖУ \n1.{product1_name} *{product1_quantity}={product1_cost}\n" +
                $"2.{product2_name} *{product2_quantity}={product2_cost}\n" +
                $"ИТОГО БЕЗ СКИДКИ = {product1_quantity * product1_cost + product2_quantity + product2_quantity * product2_cost}";
            Console.WriteLine(message);
        }

        //5. (*) Если пользователь указал месяц из зимнего периода,
        //а средняя температура > 0, вывести сообщение «Дождливая зима».
        public void RainyWinter(double averageTemperature, int numberOfMonth)
        {
            if (numberOfMonth == 1 || numberOfMonth == 2 || numberOfMonth == 12 && averageTemperature > 0)
                Console.WriteLine("Дождливая зима");
            else
            {
                Console.WriteLine($"Месяц {(Months)numberOfMonth}, среднесуточная температура {averageTemperature}");
            }
            Console.WriteLine();
        }
        
        [Flags]
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
