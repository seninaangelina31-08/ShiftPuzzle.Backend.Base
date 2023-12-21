namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        int deposit = 100;
        double interest = 0.2;
        int years = 10;
        int balance = 234;
        
        Console.WriteLine(loan_approval(balance));
        Console.WriteLine($"Your balance after deposit withdrawal: {deposit_withdrawal(deposit, balance)}");
        Console.WriteLine($"Your profit after {years} years: {calculate_compound_interest(deposit, interest, years) - deposit}");
        
    }

    public static string loan_approval(int balance){
        if (balance <= 0){
            return "Loan approval!";
        }
        else{
            return "You have enough money";
        }
    }

    public static int deposit_withdrawal(int deposit, int balance){
        return balance - deposit;
    }

    public static double calculate_compound_interest(int deposit, double interest, int years){
        double sum = deposit * Math.Pow((1 + interest), years);
        return sum;
    }
}
