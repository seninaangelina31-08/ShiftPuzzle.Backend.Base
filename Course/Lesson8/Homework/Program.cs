
Console.WriteLine(calculate_compound_interest(100, 50, 2));

string loan_approval(int balance)
{
    if (balance <= 0) return "Кредит одобрен!";
    else return "У вас достаточно средств, кредит не нужен.";
}
int deposit_withdrawal(int deposit, int balance)
{
    return balance - deposit;
}
int calculate_compound_interest(int deposit, int percent, int years, int years_01 = 0)
{
    if (years <= years_01) return deposit;
    Console.WriteLine(deposit);
    deposit += (deposit * 1000 / 100 * percent) / 1000;
    years_01++;
    return calculate_compound_interest(deposit, percent, years, years_01);
}