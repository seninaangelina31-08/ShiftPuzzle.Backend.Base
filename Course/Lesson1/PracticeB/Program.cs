
static void Main(string[] args) {
    // Ввод двух чисел
     Console.Write("Введите первое число: ");
     double num1 = Convert.ToDouble(Console.ReadLine())

    Console.Write("Введите второе число: ");
    double num2 = Convert.ToDouble(Console.ReadLine())

    // Выполнение арифметических операций
    double sum = num1 + num2;
    double diff = num1 - num2;
    double prod = num1 * num2;
     double quot = num1 / num2;

    // Вывод результатов
    Console.WriteLine("Сумма: " + sum);
     Console.WriteLine("Разность: " + diff);
    Console.WriteLine("Произведение: " + prod);
    Console.WriteLine("Частное: " + quot);
    }