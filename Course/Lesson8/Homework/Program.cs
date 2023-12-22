namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        double balance = 100;

        double bankProfit;
        balance = InterestCalculation(50, balance, out bankProfit);
        Console.WriteLine($"Баланс после снятия: {balance}, прибыль банка: {bankProfit}");

        balance = DepositWithdrawal(50, balance);
        Console.WriteLine($"Баланс после вклада: {balance}");

        string loanStatus = LoanApproval(balance);
        Console.WriteLine(loanStatus);

        double compoundInterest = CalculateCompoundInterest(1000, 0.05, 5);
        Console.WriteLine($"Конечная сумма с учетом сложного процента: {compoundInterest}");
    }

    static string LoanApproval(double balance)
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

    static double InterestCalculation(double amountToWithdraw, double balance, out double bankProfit)
    {
        double interest = amountToWithdraw * 0.05;
        double newBalance = balance - interest;
        bankProfit = interest;

        return newBalance;
    }

    static double DepositWithdrawal(double deposit, double balance)
    {
        return balance - deposit;
    }

    static double CalculateCompoundInterest(double principal, double interestRate, int years)
    {
        double compoundInterest = principal * Math.Pow((1 + interestRate), years);
        
        return compoundInterest;
    }
}