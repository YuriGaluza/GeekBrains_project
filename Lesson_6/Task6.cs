using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Level_1.Lesson_6
{
    public class Task6
    {
        private List<ToDo> ToDoList;
        private List<Employee> EmployeeList;

        public Task6(List<ToDo> toDoList, List<Employee> employeeList)
        {
            ToDoList = toDoList;
            EmployeeList = employeeList;
        }
        
        public void AddToDo(ToDo toDo)
        {
            ToDoList.Add(toDo);
        }
        
        //1. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
        public void SaveCatalogsTree()
        {
            string path = @"C:\Users\Юрий\source\repos\Level_1";
            string fileName = @"C:\Users\Юрий\source\repos\Level_1\Lesson_6\catalog_tree.txt";
            File.Delete(fileName);

            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException();
 
            Console.WriteLine('\t' + path);
            RecurrentDirectoryTree(new DirectoryInfo(path).GetDirectories(), 1);
        }
        
        void RecurrentDirectoryTree(DirectoryInfo[] directories, int leftIndent)
        {
            string fileName = @"C:\Users\Юрий\source\repos\Level_1\Lesson_6\catalog_tree.txt";

            foreach (DirectoryInfo dir in directories)
            {
                string dirNames = new string(' ', leftIndent * 2) + ">" + dir.Name;
                File.AppendAllLines(fileName, new[] { dirNames });
                Console.WriteLine(dirNames);
                
                RecurrentDirectoryTree(dir.GetDirectories(), leftIndent + 1);
                
                foreach (var file in dir.GetFiles())
                {
                    string fileNames = new string(' ', (leftIndent + 1) * 2) + ">" + file.Name;
                    File.AppendAllLines(fileName, new[] { fileNames });
                    Console.WriteLine(fileNames);
                }
            }
        }

        public void GetDirectoryTree()
        {
            string path = @"C:\Users\Юрий\source\repos\Level_1";
 
            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(path);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
        }
        
        // написать приложение для ввода списка задач;
        // задачу описать классом ToDo с полями Title и IsDone;
        // на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
        // если задача выполнена, вывести перед её названием строку «[x]»;
        // вывести порядковый номер для каждой задачи;
        // при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
        // записать актуальный массив задач в файл tasks.json/xml/bin.

        public void GetToDoListFromJson()
        {
            string path = @"C:\Users\Юрий\source\repos\Level_1\Lesson_6\tasks.json";
            string json = File.ReadAllText(path);
            List<ToDo> toDoList = JsonSerializer.Deserialize<List<ToDo>>(json);
            ToDoList = toDoList;
            
            foreach (ToDo toDo in ToDoList)
            {
                if (toDo.IsDone1)
                    Console.WriteLine($"[x] {toDo.Number1}. {toDo.Title1}");
                else
                    Console.WriteLine($"{toDo.Number1}. {toDo.Title1}");
            }
        }

        public void SerializeToDoListToJson(List<ToDo> toDoList)
        {
            string path = @"C:\Users\Юрий\source\repos\Level_1\Lesson_6\tasks.json";
            string json = JsonSerializer.Serialize(toDoList);
                
            File.WriteAllText(path,json);
            Console.WriteLine($"{toDoList} has been saved to file {path}");
        }

        public void ChangeIsDoneStatusInToDoList()
        {
            Console.Write("Введите номер задачи, которую нужно пометить как выполненную ");
            int toDoNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ToDoList.Count; i++)
            {
                if (i == toDoNumber - 1)
                {
                    ToDoList1[i].IsDone1 = true;
                    Console.WriteLine($"Задача {ToDoList1[i]} отмечена как выполненная");
                }
            }
            SerializeToDoListToJson(ToDoList);
        }

        // 3. Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4,
        // при подаче массива другого размера необходимо бросить исключение MyArraySizeException.
        //     Далее метод должен пройтись по всем элементам массива, преобразовать в int, и просуммировать.
        //     Если в каком-то элементе массива преобразование не удалось
        //     (например, в ячейке лежит символ или текст вместо числа), должно быть брошено исключение MyArrayDataException,
        // с детализацией в какой именно ячейке лежат неверные данные.
        //     В методе main() вызвать полученный метод, обработать возможные исключения MySizeArrayException
        // и MyArrayDataException, и вывести результат расчета.

        public void SumOfArrayElements(string[,] strings)
        {
            int rows = strings.GetUpperBound(0) + 1;
            int columns = strings.Length / rows;
            int result = 0;

            if ((rows != 4 || columns != 4))
            {
                throw new MyArraySizeException("Массив должен быть размером 4 x 4");
            }

            foreach (string str in strings)
            {
                result += Int32.Parse(str);
            }
            Console.WriteLine($"Сумма элементов массива {strings} равна {result}");
        }

        public void ExecuteSumOfArrayElements(string[,] strings)
        {
            try
            {
                SumOfArrayElements(strings);
            }
            catch (MyArraySizeException e)
            {
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Элементы массива должны быть типа int", e);
            }
        }

        // 4.Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
        // Конструктор класса должен заполнять эти поля при создании объекта;
        // Внутри класса «Сотрудник» написать метод, который выводит информацию об объекте в консоль;
        // Создать массив из 5 сотрудников
        //
        // Пример:
        // Person[] persArray = new Person[5]; // Вначале объявляем массив объектов
        // persArray[0] = new Person("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 30000, 30);
        // потом для каждой ячейки массива задаем объект
        // persArray[1] = new Person(...);
        // ...
        // persArray[4] = new Person(...);
        // С помощью цикла вывести информацию только о сотрудниках старше 40 лет;

        public void GetEmployeesByAge(int lowerAgeLimit)
        {
            foreach (Employee employee in EmployeeList)
            {
                if (employee.Age >= lowerAgeLimit)
                {
                    employee.GetInfo();
                }
            }
        }

        public List<ToDo> ToDoList1
        {
            get => ToDoList;
            set => ToDoList = value;
        }

        public List<Employee> EmployeeList1
        {
            get => EmployeeList;
            set => EmployeeList = value;
        }
    }
}