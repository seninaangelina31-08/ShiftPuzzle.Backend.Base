namespace Task4;
class Program
/***4.Простой счетчик:**
Напишите программу, которая использует переменную для подсчета количества раз, которое пользователь нажал на клавишу Enter.

*/
{
    static void Main(string[] args)
    {
        int count = 0;
        while(true)
        {
            Console.ReadLine();
            count = count + 1;
            Console.WriteLine("Нажали Enter: " + count + " раз.");

        }
    }
}
