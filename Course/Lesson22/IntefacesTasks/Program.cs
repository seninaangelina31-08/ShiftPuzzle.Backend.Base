using System;

interface IDanceable
{
    void Dance();
}

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
        Console.WriteLine("Я танцую, как будто  никто не видит!");
    }

    public void Sing()
    {
        Console.WriteLine("Ла ла ла! Я певчая сенсация!");
    }
}

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
    }
}