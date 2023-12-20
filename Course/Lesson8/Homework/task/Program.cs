using System;

namespace LoanApprovalApp
{
    class Program
    {
        static string LoanApproval(int balance)
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

        static int InterestCalculation(int amountToWithdraw, int balance, out int bankProfit)
        {
            int interest = amountToWithdraw * 5/100;
            int newBalance = balance - interest;
            bankProfit = interest;
            return newBalance;
        }

        static int DepositWithdrawal(int deposit, int balance)
        {
            return balance - deposit;
        }

        static void Main(string[] args)
        {
            int balance = 100;
            int bankProfit = 0;

            balance = InterestCalculation(50, balance, out bankProfit);
            Console.WriteLine($"Баланс после снятия: {balance}, прибыль банка: {bankProfit}");

            balance = DepositWithdrawal(50, balance);
            Console.WriteLine($"Баланс после вклада: {balance}");

            string loanStatus = LoanApproval(balance);
            Console.WriteLine(loanStatus);
        }
        static double calculate_compound_interest(double deposit, double interest, int years)
        {
        double amount = deposit * Math.Pow((1 + interest/100), years);
        return amount;
        }
    }
}