namespace task2;
class Program
{
     static void Main(string[] args)
        {
            Console.WriteLine("Угадайте число от 1 до 100, у вас 10 попыток : ");           
            Random rnd = new Random();
            int chislo = rnd.Next(1 , 100);
            bool isFound = false;
            for (int i = 0; i < 10; i++)
            {             
                int vvod = Convert.ToInt32(Console.ReadLine());
                if (vvod < chislo)
                {
                    Console.WriteLine("Загаданное число больше, чем то, которое вы ввели");
                    
                } 
                if (vvod > chislo)
                {
                    Console.WriteLine("Загаданное число меньше, чем то, которое вы ввели");
                   
                }
                 else if (vvod == chislo)
                {
                    isFound = true;
                    break;
                }
                Console.WriteLine(isFound ? $"Вы угадали! Загаданное число : {chislo}" : "Вы израсходовали все попытки!");
            } 
 
        }
}
