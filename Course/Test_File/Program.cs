namespace Test_File;

class Program
{
    static void Main(string[] args)
    {



    Random random = new Random();
    int number = random.Next(1,10);
    Console.WriteLine(number);


    int i = 5; //Число
    int b = 5;
    string str; //Строка
    str= i.ToString() + b.ToString();

Console.WriteLine(str);

    for (int x = 0; x <= 10; ++x )
    {
        for (int y = 0; y <= 10; ++y )
        {
            for ( int z = 0; z <= 10; ++z)
            {
                for ( int h = 0; h <= 10; ++h)
                {
                //count++;
                string generatedpass = x.ToString() + y.ToString() + z.ToString() + h.ToString();
                Console.WriteLine(generatedpass);
                }
            }
        }
    }


    }
}
