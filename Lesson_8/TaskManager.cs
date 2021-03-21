using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Level_1.Lesson_8
{
    //1. Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы
    //   и позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов
    //   с помощью указания его ID или имени процесса.В качестве примера
    //   можно использовать консольные утилиты Windows tasklist и taskkill.
    class TaskManager
    {
        public void run()
        {
            string[] commands = {""};

            while (commands[0] != "stop")
            {
                Console.Write("Введите команду: ");
                commands = stringToStringArray(Console.ReadLine());

                if (commands[0] == "all")
                    showAllProcesses();

                if (commands[0] == "kill" && commands[1] == "id")
                    killProcessById(commands[2]);

                if (commands[0] == "kill" && commands[1] == "name")
                    killProcessByName(commands[2]);
            }
        }

        public void showAllProcesses() //Выводит в консоль все процессы
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
            }
        }

        public void killProcessById(string id) //Завершает процесс по id, заданному в строковом виде
        {
            Process process = Process.GetProcessById(Convert.ToInt32(id));
            process.Kill();
            Console.WriteLine($"Процесс с id = {id} завершён");
        }

        public void killProcessByName(string name) //Завершает процесс по имени
        {
            Process[] processes = Process.GetProcessesByName(name);
            foreach (Process process in processes)
            {
                Console.WriteLine($"Процесс с именем = {name} и id = {process.Id} завершён");
                process.Kill();
            }
        }

        //Преобразует строку в массив строк, используя пробел в качестве разделителя 
        public string[] stringToStringArray(string str)
        {
            return str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
