using System;

// Настрой интерфейсы для шутников и клоунов так чтобы все заработало 

// Шуточный интерфейс "Способность танцевать"
interface IDanceable
{
    string Dance {get;}
}

// Шуточный интерфейс "Способность петь"
interface ISingable
{
    string Sing {get;}
}


internal interface ITalkable
{
    string Talk {get;}
}

internal interface IJokeable
{
    string TellJoke {get;}
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
class Clown: ITalkable, IJokeable
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
         

        ITalkable jokerTalkable = new Joker();
        IJokeable jokerJokeable = new Joker();
        IDanceable jokerDanceable = new Joker();
        ISingable jokerSingable = new Joker();

        Console.WriteLine(jokerTalkable.Talk);
        Console.WriteLine(jokerJokeable.TellJoke);
        Console.WriteLine(jokerDanceable.Dance);
        Console.WriteLine(jokerSingable.Sing);



        ITalkable clownTalkable = new Clown();
        IJokeable clownJokeable = new Clown();

        Console.WriteLine(clownTalkable.Talk);
        Console.WriteLine(clownJokeable.TellJoke);
    }
}
