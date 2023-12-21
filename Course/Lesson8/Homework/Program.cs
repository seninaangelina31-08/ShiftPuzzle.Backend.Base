namespace Homework;
class Program
{
    public static (double, double) interest_calculation(double amountToWithdraw, double balance)
    {
        double interest = amountToWithdraw * 0.05;
        double newBalance = balance - interest;
        double bankProfit = interest;
        return (newBalance, bankProfit);
    }

    public static double deposit_withdrawal(double deposit, double balance)
    {
        return balance - deposit;
    }
    public static double calculate_compound_interest(double principal, double annualRate, int years)
    {
        double amount = principal * Math.Pow((1 + (annualRate / 100)), years);
        return amount;
    }

    static void Main(string[] args)
    {
         double balance = 100;
        
        (balance, double bankProfit) = interest_calculation(50, balance);
        Console.WriteLine($"Баланс после снятия: {balance}, прибыль банка: {bankProfit}");

        balance = deposit_withdrawal(50, balance);
        Console.WriteLine($"Баланс после вклада: {balance}");

        double kredit = calculate_compound_interest(1000000,12, 25);
        Console.WriteLine($"Стольковы выплатите банку по кредиту: {kredit}");
        
    }
}
