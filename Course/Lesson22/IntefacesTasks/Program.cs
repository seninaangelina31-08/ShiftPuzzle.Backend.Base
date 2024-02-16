using System;

// Настрой интерфейсы для шутников и клоунов так чтобы все заработало 

// Шуточный интерфейс "Способность танцевать"
interface IDanceable
{
    void Dance();
}

// Шуточный интерфейс "Способность петь"
interface ISingable
{
    void Sing();
}


internal interface ITalkable
{
    void Talk();
}

internal interface IJokeable
{
     void TellJoke();
}

// Класс шутника, реализующий ITalkable, IJokeable, IDanceable и ISingable
class Joker : ITalkable, IJokeable, IDanceable, ISingable
{
    public void Talk()
    {
        Console.WriteLine("Привет! Я мастер шуток и разговоров.");
    }

    public void TellJoke()
    {
        Console.WriteLine("Почему ученые не доверяют атомам? Потому что они составляют все!");
    }

    public void Dance()
    {
        Console.WriteLine("Я танцую, как будто никто не видит!");
    }

    public void Sing()
    {
        Console.WriteLine("Ла ла ла! Я певчая сенсация!");
    }
}


// Класс клоуна, реализующий ITalkable и IJokeable
class Clown : ITalkable, IJokeable
{
    public void Talk()
    {
        Console.WriteLine("Привет! Я здесь, чтобы заставить вас улыбнуться.");
    }

    public void TellJoke()
    {
        Console.WriteLine("Почему пугало получило награду? Потому что оно было выдающимся на своем поле!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляры шутника и клоуна 

        // Используем методы через интерфейсы
         
        ITalkable joker1 = new Joker();
        IJokeable joker2 = new Joker();
        IDanceable joker3 = new Joker();
        ISingable joker4 = new Joker();

        ITalkable clown1 = new Clown();
        IJokeable clown2 = new Clown();

        joker1.Talk();
        joker2.TellJoke();
        joker3.Dance();
        joker4.Sing();

        clown1.Talk();
        clown2.TellJoke();
    }
}
