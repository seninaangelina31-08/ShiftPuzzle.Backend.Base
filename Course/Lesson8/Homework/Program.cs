namespace Homework;

class LoanApproval
{
    public static string CheckLoanApproval(double balance)
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
}

class DepositWithdrawal
{
    public static double ModifyBalance(double deposit, double balance)
    {
        return balance - deposit;
    }
}
