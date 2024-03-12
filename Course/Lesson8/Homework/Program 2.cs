namespace Homework;
class Program
{
    public static string loan_approval(int balance)
    {
        if (balance <= 0)
        {
            return "Кредит одобрен!";
        }
        return "У вас достаточно средств, кредит не нужен.";
    }
    public static int deposit_withdrawal(int deposit, int balance)
    {
        return balance - deposit;
    }
    public static double calculate_compound_interest(double balance, double percent, int years)
    {
        for (int i = 0; i < years; i++)
        {
            balance = balance * (1.0 + percent);
        }
        return balance;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int balance = 100;
        balance = deposit_withdrawal(50, balance);
        Console.WriteLine("Баланс после вклада: " + balance);

        string loan_status = loan_approval(balance);
        Console.WriteLine(loan_status);

        Console.WriteLine(calculate_compound_interest(100, 0.5, 1));
    }
}
