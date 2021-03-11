using System;

namespace Level_1.Lesson_6
{
    //класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private string position;
        private string email;
        private string phone;
        private double salary;
        private int age;

        public Employee(string firstName, string lastName, string middleName, string position, string email, string phone, double salary, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.position = position;
            this.email = email;
            this.phone = phone;
            this.salary = salary;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Сотрудник {firstName} {middleName} {lastName}, должность: {position}, email: {email}, телефон: {phone}, зарплата: {salary}, возраст {age}");
        }
        
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string MiddleName
        {
            get => middleName;
            set => middleName = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
    }
}