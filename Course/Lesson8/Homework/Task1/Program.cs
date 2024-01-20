def loan_approval(int balance);
if (balance <= 0)
{
    Console.WriteLine("Кредит одобрен!")
}
else return
{
    Console.WriteLine("У вас достаточно средств, кредит не нужен.")
}

def deposit_withdrawal(int deposit, int balance);
{
    return balance - deposit;
}

int calculate_compound_interest(int deposit, int percent, int years, int years_01 = 0)

balance = 100;
bank_profit = interest_calculation(50, balance);
Console.WriteLine(f"Баланс после снятия: {balance}, прибыль банка: {bank_profit}");

balance = deposit_withdrawal(50, balance);
Console.WriteLine(f"Баланс после вклада: {balance}");

loan_status = loan_approval(balance);
Console.WriteLine("loan_status");