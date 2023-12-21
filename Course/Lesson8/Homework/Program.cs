namespace homework;

class Program
{
    static void Main(string[] args)
    {
        int balance = 100;
        loan_approval(balance);
        int new_balance = deposit_withdrawal(50, balance);
        Console.WriteLine($"Баланс после снятия {new_balance}");
        double task2 = calculate_compound_interest(100, 20, 1);
        Console.WriteLine(task2);
    }

    static void loan_approval(int balance)
    {
        if (balance <= 0)
        {
            Console.WriteLine("Кредит одобрен!");
        } else
        {
            Console.WriteLine("У вас достаточно средств, кредит не нужен.");
        }
    }

    static int deposit_withdrawal(int deposit, int balance)
    {
        return balance - deposit;
    }


    static double calculate_compound_interest(int summa, double percent, int num_years)
    {   
        double procent = 1 + (percent / 100);
        double ctepen = Convert.ToDouble(num_years);
        return summa * Math.Pow(procent, ctepen);
    }
}
