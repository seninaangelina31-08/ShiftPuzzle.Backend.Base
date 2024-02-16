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
class Joker  : IDanceable, ISingable, ITalkable, IJokeable
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
class Clown  : ITalkable, IJokeable
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
         
        ITalkable Talk_clown = new Clown();
        Talk_clown.Talk();
        IJokeable Joke_clown = new Clown();
        Joke_clown.TellJoke();


        IDanceable Dance_Joker = new Joker();
        Dance_Joker.Dance();
        ISingable Sing_Joker = new Joker();
        Sing_Joker.Sing();
        ITalkable Talk_Joker = new Joker();
        Talk_Joker.Talk();
        IJokeable Joke_Joker = new Joker();
        Joke_Joker.TellJoke();
        
    }
}
