
using System;
using System.Collections.Generic;

namespace meow
{
    //Определение класса:
    //Создайте класс Person с двумя полями: name и age. Напишите код для создания экземпляра класса и установите эти поля через прямое обращение к ним.  
    public class Person
    {
        public string name;
        public int age;
        //Использование конструктора:
        //Добавьте конструктор в класс Person, который позволит установить name и age при создании объекта.
        public Person(string pName, int pAge)
        {
            name = pName;
            queAge(pAge);
        }
   

        //Добавление метода: 
        //Добавьте в класс Person метод Introduce, который будет печатать сообщение в консоль, вроде "Привет, мое имя [имя]".
        public void Introduce()
        {
            Console.WriteLine("Привет, мое имя " + name);
        }
        //Cоздайте функцию внутри класса Person которая устанаивалиает значения для age осуществляя проверку на отрицательное значение
         public void queAge(int pAge)
        {
            if (pAge >= 0)
            {
                age = pAge;
            }
            else
            {
                Console.WriteLine("Ошибка. Возраст отрицательный.");
            }
        }
    }

    //Создайте класс Employee, который наследуется от Person и добавляет поле position. 
    public class Employee : Person
    {
        public int position;

        private static int i = 1;

        public Employee(string pName, int pAge) : base(pName, pAge)
        {
            position = i;
            i++;
        }

        public void Posit()
        {
            Console.WriteLine("Позиция в списке: " + position);
        }
        
    }

    public class Program
    {
        public static void Main()
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Employee("Шурик", 25);
            employees[1] = new Employee("Жора", 26);
            employees[2] = new Employee("Платон", 27);
        //Работа с массивами объектов:
        //Создайте массив из объектов Person и используйте цикл для вызова метода Introduce для каждого элемента массива.
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Introduce();
                employees[i].Posit();
                
            }
        }
    }
}