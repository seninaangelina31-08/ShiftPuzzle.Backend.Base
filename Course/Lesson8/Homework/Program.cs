namespace homework;

class Program
{
    static String loan_approval(int balance)
    {
        if (balance <= 0)
        {
            return "Кредит одобрен!";
        }
        else
        {
            return "У вас достаточно средст, кредит не нужен";
        }
    }
    int deposit_withdrawal(int deposit, int balance)
    {
        return balance - deposit;
    }
    
    static int calculate_compound_interest(int startSum, int proch, int numYear)
    {
        if (numYear <= 1)
        {
            return startSum + (startSum * proch);
        }
        else
        {
            return calculate_compound_interest(startSum + (startSum * proch), proch, numYear - 1);
        }
    }
}
