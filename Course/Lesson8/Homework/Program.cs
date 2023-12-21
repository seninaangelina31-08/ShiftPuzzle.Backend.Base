namespace Homework;

class Program
{
    public static string Loan_Approval(double balance)
    {
        if (balance <= 0)
        {
            return "Кредит одобрен!";
        }
        else
        {
            return "У вас достаточно средств, кредит не нужен.";
        }
    }

    public static (double, double) Interest_Calculation(double amountToWithdraw, double balance)
    {
        double interest = amountToWithdraw * 0.05;
        double newBalance = balance - interest;
        double bankProfit = interest;
        return (newBalance, bankProfit);
    }

    static double Deposit_Withdrawal(double deposit, double balance)
    {
        return balance - deposit;
    }

    public static double Calculate_Compound_Interest(double principal, double annualRate, int years)
{
    if (years == 0)
    {
        return principal;
    }
    else
    {
        double amount = principal + principal * annualRate;
        return Calculate_Compound_Interest(amount, annualRate, years - 1);
    }
}

    
    static void Main(string[] args)
    {
     
     double balance = 100;
        (balance, double bankProfit) = Interest_Calculation(50, balance);
        Console.WriteLine($"Баланс после снятия: {balance}, прибыль банка: {bankProfit}");

        balance = Deposit_Withdrawal(50, balance);
        Console.WriteLine($"Баланс после вклада: {balance}");

        string loanStatus = Loan_Approval(balance);
        Console.WriteLine(loanStatus);   
    }
}
