using System;

// Настрой интерфейсы для шутников и клоунов так чтобы все заработало 

// Шуточный интерфейс "Способность танцевать"
interface IDanceable
{
<<<<<<< HEAD
    string Dance {get;}
=======
 
>>>>>>> 240f7224 (feat: added answer to task 21)
}

// Шуточный интерфейс "Способность петь"
interface ISingable
{
<<<<<<< HEAD
    string Sing {get;}
=======
 
>>>>>>> 240f7224 (feat: added answer to task 21)
}


internal interface ITalkable
{
<<<<<<< HEAD
    string Talk {get;}
=======
  
>>>>>>> 240f7224 (feat: added answer to task 21)
}

internal interface IJokeable
{
<<<<<<< HEAD
    string TellJoke {get;}
}

// Класс шутника, реализующий ITalkable, IJokeable, IDanceable и ISingable
class Joker : ITalkable, IJokeable, IDanceable, ISingable
=======
     
}

// Класс шутника, реализующий ITalkable, IJokeable, IDanceable и ISingable
class Joker  
>>>>>>> 240f7224 (feat: added answer to task 21)
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
<<<<<<< HEAD
class Clown: ITalkable, IJokeable
=======
class Clown  
>>>>>>> 240f7224 (feat: added answer to task 21)
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
         

<<<<<<< HEAD
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
=======
        
>>>>>>> 240f7224 (feat: added answer to task 21)
    }
}
