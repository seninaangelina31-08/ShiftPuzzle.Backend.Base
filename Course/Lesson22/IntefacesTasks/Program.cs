using System;

// Настрой интерфейсы для шутников и клоунов так чтобы все заработало 

// Шуточный интерфейс "Способность танцевать"
interface IDanceable
{
 public void CanDance();
}

// Шуточный интерфейс "Способность петь"
interface ISingable
{
    public void CanSing();
}


internal interface ITalkable
{
    public void CanTalk();
}

internal interface IJokeable
{
     public void CanJoke();
}

// Класс шутника, реализующий ITalkable, IJokeable, IDanceable и ISingable
class Joker : ITalkable, IJokeable, IDanceable, ISingable
{
    public void CanTalk()
    {
        Console.WriteLine("Привет! Я мастер шуток и разговоров.");
    }

    public void CanJoke()
    {
        Console.WriteLine("Почему ученые не доверяют атомам? Потому что они составляют все!");
    }

    public void CanDance()
    {
        Console.WriteLine("Я танцую, как будто никто не видит!");
    }

    public void CanSing()
    {
        Console.WriteLine("Ла ла ла! Я певчая сенсация!");
    }
}


// Класс клоуна, реализующий ITalkable и IJokeable
class Clown  : ITalkable, IJokeable
{
    public void CanTalk()
    {
        Console.WriteLine("Привет! Я здесь, чтобы заставить вас улыбнуться.");
    }

    public void CanJoke()
    {
        Console.WriteLine("Почему пугало получило награду? Потому что оно было выдающимся на своем поле!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляры шутника и клоуна 
        IDanceable jokerDance = new Joker();
        ITalkable jokerTalk = new Joker();
        ISingable jokerSing = new Joker();
        IJokeable jokerJoke = new Joker();

        ITalkable clownTalk = new Clown();
        IJokeable clownJoke = new Clown();
        // Используем методы через интерфейсы
        jokerDance.CanDance();
        jokerTalk.CanTalk();
        jokerSing.CanSing();
        jokerJoke.CanJoke();

        clownTalk.CanTalk();
        clownJoke.CanJoke(); 

        
    }
}
