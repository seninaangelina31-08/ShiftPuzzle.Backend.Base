using System;
using System.Collections.Generic;
namespace PracticeA
{
    public class Transaction
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public double Amount { get; set; }
    }
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }
        public string AccountHolder { get; set; }

        public BankAccount(int accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0;
        }
        public List<Transaction> TransactionHistory { get; private set; } = new List<Transaction>();

        public void RecordTransaction(int fromAccount, int toAccount, double amount)
        {
            TransactionHistory.Add(new Transaction { FromAccount = fromAccount, ToAccount = toAccount, Amount = amount });
        }

        public Transaction GetLastTransaction()
        {
            if (TransactionHistory.Count > 0)
            {
                return TransactionHistory[TransactionHistory.Count - 1];
            }
            return null;
        }

        public void RemoveLastTransaction()
        {
            if (TransactionHistory.Count > 0)
            {
                TransactionHistory.RemoveAt(TransactionHistory.Count - 1);
            }
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }

    public class Bank
    {
        private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
        private int nextAccountNumber = 1000;

        // 1. Получение счета
        public BankAccount GetAccount(int accountNumber)
        {

            if (accounts.ContainsKey(accountNumber))
            {
                return accounts[accountNumber];
            }
            return null;
        }

        // 2. Отправка денег
        public bool Transfer(int fromAccountNumber, int toAccountNumber, double amount)
        {
            var fromAccount = GetAccount(fromAccountNumber);
            var toAccount = GetAccount(toAccountNumber);

            if (fromAccount != null && toAccount != null && fromAccount.Withdraw(amount))
            {
                toAccount.Deposit(amount);
                toAccount.RecordTransaction(fromAccountNumber, toAccountNumber, amount);
                return true;
            }
            return false;
        }

        // 3. Отмена операции
        // Пример простой системы отмены (в реальности это было бы сложнее)
        public bool CancelLastTransaction(int accountNumber)
        {
            // Логика отмены последней транзакции (зависит от реализации системы) 
            var account = GetAccount(accountNumber);
            var lastTransaction = account?.GetLastTransaction();
        
            if (lastTransaction != null && lastTransaction.FromAccount == accountNumber)
            {
                var toAccount = GetAccount(lastTransaction.ToAccount);
                if (toAccount != null && toAccount.Withdraw(lastTransaction.Amount))
                {
                    account.Deposit(lastTransaction.Amount);
                    account.RemoveLastTransaction();
                    toAccount.Withdraw(lastTransaction.Amount);
                    toAccount.RemoveLastTransaction();
                    return true;
                } return false;
            }
            return false;
        }   
        

        // 4. Показать остаток
        public double CheckBalance(int accountNumber)
        {
            var account = GetAccount(accountNumber);
            return account.Balance;
        }

        // 5. Выписка по счету
        public void PrintStatement(int accountNumber)
        {
            var account = GetAccount(accountNumber);
            if (account != null)
            {
                Console.WriteLine($"Account: {account.AccountHolder}, Balance: {account.Balance}");
            }
        }

        // 6. Открытие нового счета
        public BankAccount OpenAccount(string accountHolder)
        {
            var account = new BankAccount(nextAccountNumber++, accountHolder);
            accounts.Add(account.AccountNumber, account);
            return account;
        }

        // 7. Закрытие счета
        public bool CloseAccount(int accountNumber)
        {
            return accounts.Remove(accountNumber);
        }

        // 8. Запрос кредита
        public bool RequestLoan(int accountNumber, double loanAmount)
        {
            var account = GetAccount(accountNumber);
            if (account != null)
            {
                account.Deposit(loanAmount);
                return true;
            }
            return false;
        }

        // 9. Платеж по кредиту
        public void GetLoan(int accountNumber, double amount)
        {
            var account = GetAccount(accountNumber);
            account.Withdraw(amount);
        }

        // 10. Изменение личных данных клиента
        public void UpdateAccountHolderInfo(int accountNumber, string newName)
        {
            var account = GetAccount(accountNumber);
            if (account != null)
            {
                account.AccountHolder =  newName;
            }
        }
    }
}