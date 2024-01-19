using System;

namespace Homework {
    class Program {
         public static string LoanApproval(double balance) {
            if (balance <= 0) {
                return "Кредит одобрен!";
            }
            else {
                return "У вас достаточно средств, кредит не нужен.";
            }
        }

        public static (double, double) InterestCalculation(double amountToWithdraw, double balance) {
            double interest = amountToWithdraw * 0.05;
            double newBalance = balance - interest;
            double bankProfit = interest;
            return (newBalance, bankProfit);
        }

        static double DepositWithdrawal(double deposit, double balance) {
            return balance - deposit;
        }

        public static double CalculateCompoundInterest(double principal, double annualRate, int years) {
            if (years == 0) {
                return principal;
            }
            double amount = principal + principal * annualRate;
            return CalculateCompoundInterest(amount, annualRate, years - 1);
        }

        
        static void Main(string[] args) {
            double balance = 100;
            double bankProfit;

            (balance, bankProfit) = InterestCalculation(50, balance);
            Console.WriteLine($"Баланс после снятия: {balance}, прибыль банка: {bankProfit}");

            balance = DepositWithdrawal(50, balance);
            Console.WriteLine($"Баланс после вклада: {balance}");

            string loanStatus = LoanApproval(balance);
            Console.WriteLine(loanStatus);
            // Резюме - C# - топ язык :)
        }
    }
}
