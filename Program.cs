using System;
using System.Collections.Generic;
using Level_1.Lesson_1;
using Level_1.Lesson_2;
using Level_1.Lesson_3;
using Level_1.Lesson_4;
using Level_1.Lesson_5;
using Level_1.Lesson_6;
using Level_1.Lesson_7;

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

            // Task4 task4 = new Task4();
            // task4.GetFullName("Путин", "Владимир", "Владимирович");
            // task4.GetFullName("Келдыш", "Мстислав", "Всеволодович");
            // task4.GetFullName("Крамник", "Владимир", "Борисович");
            // task4.SumOfNumbersFromString("1 2 3 4");
            // task4.GetSeasonByMonthNumber();
            // task4.ShowFibonacciNumber();

            // Task5 task5 = new Task5();
            // task5.SaveDataToTextFile();
            // task5.SaveCurrentTimeToTextFile();
            // task5.SaveNumberSetInBinaryFile();

            //Task6 task6 = new Task6(new List<ToDo>(), new List<Employee>());
            //task6.SaveCatalogsTree();
            //task6.GetDirectoryTree();

            // List<ToDo> toDos = new List<ToDo>();
            // toDos.Add(new ToDo("Make task1", false, 1));
            // toDos.Add(new ToDo("Make task2", false, 2));
            // toDos.Add(new ToDo("Make task3", false, 3));
            // toDos.Add(new ToDo("Make task4", false, 4));
            // toDos.Add(new ToDo("Make task5", false, 5));
            // task6.SerializeToDoListToJson(toDos);
            // task6.GetToDoListFromJson();

            // task6.ChangeIsDoneStatusInToDoList();
            // task6.SerializeToDoListToJson(task6.ToDoList1);
            // task6.GetToDoListFromJson();

            // task6.ChangeIsDoneStatusInToDoList();
            // task6.SerializeToDoListToJson(task6.ToDoList1);
            // task6.GetToDoListFromJson();
            //
            // string[,] correctArr =
            // {
            //     {"1", "2", "3", "4"},
            //     {"0", "0", "0", "0"},
            //     {"0", "0", "0", "0"},
            //     {"1", "2", "3", "4"}
            // };
            // string[,] wrongArr1 =
            // {
            //     {"0", "0", "0"},
            //     {"0", "0", "0"},
            //     {"0", "0", "0"},
            //     {"0", "0", "0"}
            // };
            // string[,] wrongArr2 =
            // {
            //     {"1", "2", "3", "d"},
            //     {"0", "0", "0", "0"},
            //     {"0", "0", "0", "0"},
            //     {"1", "2", "3", "4"}
            // };
            //task6.ExecuteSumOfArrayElements(correctArr);
            //task6.ExecuteSumOfArrayElements(wrongArr1);
            //task6.ExecuteSumOfArrayElements(wrongArr2);

            //task6.EmployeeList1 = new List<Employee>(new Employee[]
            //{
            //     new Employee("Buster", "Douglas", "", "manager",
            //         "bust@mail.ru", "25-65-65", 21.55, 24),
            //     new Employee("Ron", "Jeremy", "", "programmer",
            //         "ronny@yandex.ru", "54-43-76", 65.50, 50),
            //     new Employee("Chloe", "Michaels", "", "actress",
            //         "ChoeMich@yahoo.com", "67-87-98", 65.64, 21),
            //     new Employee("Mike", "Tyson", "", "boxer",
            //         "ironmike@gmail.com", "23-54-63", 256.29, 34),
            //     new Employee("Paul", "Anderson", "", "director",
            //         "panderson@rambler.ru", "72-47-08", 208.51, 56),
            //});
            //task6.GetEmployeesByAge(40);

            //new CrossAndZero().StartGame();
            new Task7().StartApp();
        }
    }
}

