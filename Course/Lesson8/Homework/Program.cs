namespace PracticeAB;

class Program
{

    public static string loan_approval(int balance){
        if (balance <= 0){
            return "Кредит одобрен!";
        }
        else{
            return "У вас достаточно средств, кредит не нужен.";
        }
    }

    public static int deposit_withdrawal(int deposit, int balance)
    {
        return balance - deposit;
    }




    public static void calculate_compound_interest(double sum, int pr, int year)
    {
        
        
        for (int i=1; i<=year; i++){
            sum = sum + sum/100*pr;
        }
        Console.WriteLine(sum);
    }




    static void Main(string[] args)
        {
            Console.WriteLine(loan_approval(-100));
            Console.WriteLine(deposit_withdrawal(100, 300));
            calculate_compound_interest(1000, 15, 2);
        }
}


