using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1
{
    class Task1
    {
        public void HelloUser()
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
        }
    }
}
