namespace Homework;

class Program
{
    static void Main(string[] args)
    {
    int balance = 100;

    //Вызов функции одобрения кредита
    string load_impr = loan_approval(balance);
    Console.WriteLine(load_impr);

    //Вызов функции пополнения вклада
    int dep = depositw(50, balance);
    Console.WriteLine($"Текущий счет вклада: {dep}");

    //Вызов функции снятия денег прибыли банка
    Tuple<double, double> tuple = interest_calculation(50, balance);
    Console.WriteLine("Баланс после снятия: {0} Прибыль банка: {1}", tuple.Item1, tuple.Item2);
    }

static string loan_approval(int balance)
{
    string t = "Кредит одобрен";
    string f = "вас достаточно средств, кредит не нужен.";
    if (balance <= 0)
    {
        return t;
    }
    else
    {
       return f;
    }
}
static int depositw( int deposit, int balance)
{
    return deposit + balance;
}
static Tuple<double, double> interest_calculation( int amount_to_withdraw,  int balance)
{
    double interest = amount_to_withdraw * 0.05;
    double new_balance = balance - amount_to_withdraw - interest;
    double profit = interest;
    return Tuple.Create(new_balance, profit);



}









}
