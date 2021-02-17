using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1
{
    public class Task3
    {
        //1. Написать программу, выводящую элементы двухмерного массива по диагонали
        public void DiagonalElementsOfArray(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"array[{i}, {j}] = {array[i, j]}");
                    }
                }
            }
            Console.WriteLine();
        }

        //2. Написать программу — телефонный справочник — создать двумерный массив 5*2,
        //хранящий список телефонных контактов: первый элемент хранит имя контакта,
        //второй — номер телефона/e-mail.
        public void GetPhoneBook()
        {
            string[,] phoneBook = new string[,] { 
                { "Donald Trump", "+7-913-365-1256 / dontrump@yandex.ru" },
                { "Barak Obama", "+7-960-962-4356 / obamacare@mail.ru" },
                { "William Klinton", "+7-923-999-5678 / billandmonika@yahoo.com" },
                { "George Bush jr.", "+7-908-999-0983 / georgb@google.com" },
                { "James Carter", "+7-913-145-2358 / jimmycarter@inbox.ru" } 
            };

            int rows = phoneBook.GetUpperBound(0) + 1;
            int columns = phoneBook.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{phoneBook[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //3. Написать программу, выводящую введенную пользователем строку
        //в обратном порядке (olleH вместо Hello)
        public void ReverseString(string inputString)
        {
            string outputString = "";

            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                outputString += inputString[i];
            }
            Console.WriteLine(outputString);
            Console.WriteLine();
        }

        //4. * «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O,
        //где Х — элементы кораблей, а О — свободные клетки.
        public void BattleShip()
        {
            string[,] cells = new string[,] {
                { "0", "X", "X", "0", "0", "0", "X", "0", "0", "0" },
                { "0", "0", "X", "0", "0", "0", "X", "0", "0", "0" },
                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                { "0", "X", "0", "0", "0", "0", "0", "0", "0", "0" },
                { "0", "X", "0", "0", "0", "0", "0", "X", "0", "0" },
                { "0", "X", "0", "0", "0", "X", "X", "X", "0", "0" },
                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                { "0", "0", "X", "X", "0", "0", "0", "0", "0", "0" },
                { "0", "0", "0", "0", "0", "X", "0", "0", "0", "0" },
                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" }
            };

            int rows = cells.GetUpperBound(0) + 1;
            int columns = cells.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{cells[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
