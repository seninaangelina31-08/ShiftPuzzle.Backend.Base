namespace Homework;

class Program
{   
    // base level

    public static string IoanApproval(float balance)
    {
        if (balance <= 0) return "Кредит одобрен";
        else return "У вас достаточно средств, кредит не нужен.";
    }


    public static float DepositWithdrawal(float deposit, float balance)
    {
        return balance - deposit;
    }

    // advanced level

    public static float CalculateCompoundInterest(int deposit, float annualInterestRate, int year)
    {
        for (int i = 0; i < year; i++)
        {
            deposit += (int)(deposit * annualInterestRate);
        }

        return deposit;
    }




    static void Main(string[] args)
    {
        Console.WriteLine(IoanApproval(1000));
        Console.WriteLine(IoanApproval(-1231));
        Console.WriteLine(DepositWithdrawal(150, 500));
        Console.WriteLine(CalculateCompoundInterest(1000, 0.1f, 5));



    }
}
