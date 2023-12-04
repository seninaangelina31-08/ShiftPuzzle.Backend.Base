static void Main(string[] args)
    {
        Console.Write("НАпиши число: ");
        string input = Console.ReadLine();

        int num = 0;
        if (int.TryParse(input, out num))
        {
            num += 5;
            Console.WriteLine("вывод: " + num);
        }
        else
        {
            Console.WriteLine("ошибка");
           }
    }
