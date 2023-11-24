using System;
using System.Collections.Generic; 

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string new_contact;
            List<string> contacts = new List<string>();
            Console.Write("Привет, я запоминалка номеров: Ты можешь: 'Добавить номер'; 'Вывести контакты' и 'Выйти' ");
            while (true) {
                Console.Write("Введи одну из комманд: ");
                command = Console.ReadLine() ?? "";
                if (command.Length == 0) {
                    Console.Write("");
                }
                else if (command == "Добавить номер") {
                    Console.WriteLine("Введите имя и номер в одну строку: ");
                    new_contact = Console.ReadLine() ?? "";
                    if (new_contact.Length == 0) {
                        Console.WriteLine("Пустое сообщение!!!");
                    }
                    else {
                        contacts.Add(new_contact);
                    }
                }
                else if (command == "Вывести контакты") {
                    Console.WriteLine("Ваши контакты: ");
                    foreach (var contact in contacts) {
                        Console.WriteLine(contact);
                    }
                }
                else if (command == "Выйти") {
                    Console.WriteLine("До встречи!!!");
                    break;
                }
            }
        }
    }
}
