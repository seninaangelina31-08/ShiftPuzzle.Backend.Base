<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Example;
=======
﻿namespace Example{
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)

class Program
{
    static void Main(string[] args)
    {
        // создание объекта тигра
        Tiger tiger = new Tiger("black-orange", 3.5f);

        // вызов метода издавания звука
        tiger.MakeSound();

        // вызов метода роста животного
        tiger.Grow();

        // обращение к полю Size
        Console.WriteLine($"Size of the tiger after growth = {tiger.Size}");
    }
}

// Базовый класс животного
public class Animal
{
    // поля класса
    public string Color;
    public float Size;
    public string Food;

    // конструктор класса
    public Animal(string color, float size, string food)
    {
        this.Color = color;
        this.Size = size;
        this.Food = food;
    }

    // метод для издавания звуков, общий для всех животных
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }

    // метод для роста животного
    public void Grow()
    {
        Size += 15;
    }
}

// Класс тигров, унаследованный от класса Animal
public class Tiger : Animal
{
    // переопределение конструктора
    public Tiger(string color, float size) : base(color, size, "Meat") {}

    // переопределение метода для издавания звука
    public override void MakeSound()
    {
        Console.WriteLine("R-r-r-r-r-r!");
    }
<<<<<<< HEAD
=======
}
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
}
=======
>>>>>>> c67de646 (I cant commit individually, when I update the branch Ill figure it out)
