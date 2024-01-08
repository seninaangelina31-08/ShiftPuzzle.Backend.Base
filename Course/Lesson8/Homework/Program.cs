namespace Homework;

class Program
{
    public string loan_approval(int balance){
        if (balance <= 0){
            return "Кредит одобрен!";
        }
        else {
            return "У вас достаточно средств, кредит не нужен.";
        }
    }
    public int deposit_withdrawal(int deposit, int balance) {
        return balance - deposit;
    }

    public float calculate_compound_interest(float balance, float percentage, int years) {
        for (int i = 0; i < years; i++) {
            balance += balance*percentage;
        }
        return balance;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
