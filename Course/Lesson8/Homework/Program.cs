namespace Homework;

class Program

{
    public string LoanApproval(int balance)
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

    public int DepositWithdrawal(int deposit, int balance)
    {
        return balance - deposit;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
    }

    public static double CalculateCompoundInterest(double nach, double procent, int years)
    {

        double con = nach * Math.Pow(1 + procent/100, years);
        return con;
    }
}
