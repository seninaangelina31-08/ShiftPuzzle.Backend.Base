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


interface ITalkable
{
    void Talk();
}

interface IJokeable
{
    void TellJoke();
}

// Класс шутника, реализующий ITalkable, IJokeable, IDanceable и ISingable
class Joker : IDanceable, ISingable, ITalkable, IJokeable
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
class Clown : IJokeable, ITalkable
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
        // IDanceable danceInter = new Joker();
        // Создаем экземпляры шутника и клоуна 
        ITalkable RedNoseT = new Clown();
        ITalkable NoFunnyJokeT = new Joker();

        IJokeable RedNoseJ = new Clown();
        IJokeable NoFunnyJokeJ = new Joker();

        ISingable NoFunnyJokeS = new Joker();

        IDanceable NoFunnyJokeD = new Joker();
        // Используем методы через интерфейсы
        
        RedNoseT.Talk();
        NoFunnyJokeT.Talk();

        NoFunnyJokeS.Sing();
    }
}
