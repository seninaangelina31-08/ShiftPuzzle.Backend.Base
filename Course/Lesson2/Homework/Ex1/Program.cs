namespace Ex1;

class Program
{
    
    static void Main(string[] args)
    {
        double pow(double a, double b)
        {
            double x = a;
            for (int i = 2; i <= b; i++)
            {
                x = x * a;
            }
            return(x);
        }
        Console.WriteLine("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите что вы хотите сделать: (+ - сложить, - - вычесть, * - умножить, / - поделить, % - узнать остаток от деления, ^ - возвести в степень)");
        string op = Console.ReadLine();
        switch (op)
        {
            case "+":
                Console.WriteLine($"{a} {op} {b} = {a + b}");
                break;
            case "-":
                Console.WriteLine($"{a} {op} {b} = {a - b}");
                break;
            case "*":
                Console.WriteLine($"{a} {op} {b} = {a * b}");
                break;
            case "/":
                Console.WriteLine($"{a} {op} {b} = {a / b}");
                break;
            case "%":
                Console.WriteLine($"{a} {op} {b} = {a % b}");
                break;
            case "^":
                Console.WriteLine($"{a} {op} {b} = {pow(a, b)}");
                break;
            default:
                break;
        }
    }
}
