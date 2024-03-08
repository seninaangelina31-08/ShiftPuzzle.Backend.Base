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
        ITalkable jokeTalk = new Joker();
        IJokeable jokeTellJoke = new Joker();
        IDanceable jokeDance = new Joker();
        ISingable jokeSing = new Joker();

        ITalkable clownTalk = new Clown();
        IJokeable clownTellJoke = new Clown();

        // Используем методы через интерфейсы
        jokeTalk.Talk();
        jokeTellJoke.TellJoke();
        jokeDance.Dance();
        jokeSing.Sing();

        clownTalk.Talk();
        clownTellJoke.TellJoke();
    }
}
