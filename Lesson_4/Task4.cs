using System;

namespace Level_1.Lesson_4
{
    public class Task4
    {
        //1. Написать метод GetFullName(string firstName, string lastName, string patronymic),
        //принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
        //Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО
        public void GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{firstName} {lastName} {patronymic}");
            Console.WriteLine();
        }
        //2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
        //и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
        public void SumOfNumbersFromString(string stringOfNumbers)
        {
            string[] numbers = stringOfNumbers.Split(" ");
            int sum = 0;
            foreach (string str in numbers)
            {
                sum += Convert.ToInt32(str);
            }
            Console.WriteLine($"Сумма чисел {stringOfNumbers} равна {sum}");
            Console.WriteLine();
        }
        
        //3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
        //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод,
        //принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
        //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
        //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
        public void GetSeasonByMonthNumber()
        {
            string input;
            while (true)
            {
                Console.Write("Введите порядковый номер месяца: ");
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                
                int numberOfMonth = Convert.ToInt32(input);

                if (numberOfMonth == 12 || numberOfMonth == 1 || numberOfMonth == 2)
                {
                    Console.WriteLine(Season.Winter);
                }
                else if (numberOfMonth > 2 && numberOfMonth <= 5)
                {
                    Console.WriteLine(Season.Spring);
                }
                else if (numberOfMonth > 5 && numberOfMonth < 9)
                {
                    Console.WriteLine(Season.Summer);
                }
                else if (numberOfMonth >= 9 && numberOfMonth <= 11)
                {
                    Console.WriteLine(Season.Autumn);
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
            }
        }
        
        //(*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
        public void ShowFibonacciNumber()
        {
            Console.Write("Введите положительное натуральное число");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input >= 0)
            {
                Console.WriteLine($"Число Фибоначчи для {input} равно {Fibonacci(input)}");
            }
            else if (input < 0)
            {
                Console.WriteLine("Вводимое число должно быть больше или равно 0");
            }
        }
        
        int Fibonacci(int number)
        {
            int result;
            if (number == 0)
            {
                result = 0;
            }
            else if (number == 1)
            {
                result = 1;
            }
            else
            {
                result = Fibonacci(number - 1) + Fibonacci(number - 2);
            }
            return result;
        }
    }
    
    

    enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
}