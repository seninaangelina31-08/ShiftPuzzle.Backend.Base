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
class Joker  
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
class Clown  
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
        Joker joker = new Joker();
        Clown clown = new Clown();

        ITalkable talkableJoker = joker;
        IJokeable jokeableJoker = joker;
        IDanceable danceableJoker = joker;
        ISingable singableJoker = joker;

        talkableJoker.Talk();
        jokeableJoker.TellJoke();
        danceableJoker.Dance();
        singableJoker.Sing();

        ITalkable talkableClown = clown;
        IJokeable jokeableClown = clown;

        talkableClown.Talk();
        jokeableClown.TellJoke();
        // Используем методы через интерфейсы
         

        
    }
}
