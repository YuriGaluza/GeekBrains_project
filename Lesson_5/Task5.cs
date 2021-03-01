using System;
using System.Collections;
using System.IO;

namespace Level_1.Lesson_5
{
    public class Task5
    {
        //1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
        public void SaveDataToTextFile()
        {
            Console.Write("Введите данные");
            string data = Console.ReadLine();
            string path = @"C:\Users\Юрий\source\repos\Level_1\Lesson_5\data.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(data);
                }

                Console.WriteLine($"Запись данных в файл {path} выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
        public void SaveCurrentTimeToTextFile()
        {
            string path = @"C:\Users\Юрий\source\repos\Level_1\Lesson_5\startup.txt";
            
            DateTime currentTime = DateTime.Now;

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(currentTime.ToString("T"));
                }

                Console.WriteLine($"Текущее время записано в файл {path}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
        public void SaveNumberSetInBinaryFile()
        {
            string filePath = @"C:\Users\Юрий\source\repos\Level_1\Lesson_5\bytes.bin";
            Console.Write("Введите набор целых чисел через пробел");
            string input = Console.ReadLine();
            string[] numbers = null;

            try
            {
                numbers = input.Split(" ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Введите набор целых чисел через пробел");
            }

            byte[] numberArray = new byte[numbers.Length];
            
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = Convert.ToByte(numbers[i]);

            }
            File.WriteAllBytes(filePath, numberArray);
            Console.Write($"Введите набор байтов записан в {filePath}");
        }
    }
}

















