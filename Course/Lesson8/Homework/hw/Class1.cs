namespace hw;

class Class1
{
    
    public static void Main(string[] args) {
        double balance = 100;
        Console.WriteLine(loan_approval(balance));
        
        double deposit = 50;
        Console.WriteLine(deposit_withdrawal(deposit, balance));

        double iAmount = 1000;
        double aInterestR = 5;
        int numOfYears = 10;

        double finalAmount = calculate_compound_interest(iAmount, aInterestR, numOfYears);
        Console.WriteLine("Конечная сумма: " + finalAmount);

    }

    public static string loan_approval(double balance) {
        if (balance <= 0) {
            return "Кредит одобрен!";
        } else {
            return "У вас достаточно средств, кредит не нужен.";
        }
    }

    public static double deposit_withdrawal(double deposit, double balance) {
        return balance - deposit;
    }

    public static double calculate_compound_interest(double initialAmount, double annualInterestRate, int numOfYears)
    {
    double annualInterest = initialAmount * (annualInterestRate / 100);

    double finalAmount = initialAmount;
    for (int i = 0; i < numOfYears; i++)
    {
        finalAmount += annualInterest;
        annualInterest = finalAmount * (annualInterestRate / 100);
    }

    return finalAmount;
    }
}
