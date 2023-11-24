namespace HW1;
class Program
/*Создайте калькулятор, который принимает два числа от пользователя, сохраняет их в переменных, складывает их и выводит результат.*/
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int count_1 = Int32.Parse(Console.ReadLine());
        int count_2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Сумма: " + (count_1 + count_2));
    }
}
