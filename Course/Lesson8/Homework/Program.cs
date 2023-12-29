namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        static string loan_approval(int balance)
        {
            if (balance <= 0)
                return "Кредит одобрен";
            else
                return "У вас достаточно средств, кредит не нужен.";
        }

        static int deposit_withdrawal(int deposit, int balance)
        {
            return balance - deposit;
        }

        static int calculate_compound_interest(int deposit, int proc, int age)
        {
            for(int i = 0; i < age; i++)
            {
                calculate_compound_interest(deposit += deposit*proc/100, proc, age-1);
            }
            return(deposit);
        } 

        int balance = 100;
        balance = deposit_withdrawal(50, balance);
        Console.WriteLine($"Баланс после вклада: {balance}");

        string loan_status = loan_approval(balance);
        Console.WriteLine($"{loan_status}");
        
        Console.WriteLine($"{calculate_compound_interest(100, 13, 7)}");
    }
}
