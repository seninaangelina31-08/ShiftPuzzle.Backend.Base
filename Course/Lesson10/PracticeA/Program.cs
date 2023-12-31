﻿using System;
using System.IO;

﻿namespace PracticeA {
    class FileOperations {
        static void Main(string[] args) {
            Write();
            Read();
            // чтение запись в файл test.txt
        }
        
        public static void Write() {
            string text = "Практика A\nУспешно была выполнена!\nРабота с файлами\nТеперь покорена :)";
            File.WriteAllText("test.txt", text);
        }

        public static void Read() {
            string[] lines = File.ReadAllLines("test.txt");
            foreach(string line in lines) {
                Console.WriteLine(line);
            }
        }
    }
}
