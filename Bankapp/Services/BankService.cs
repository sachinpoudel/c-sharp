using System.Security.AccessControl;
using Bankapp.Models;
using Bankapp.Notifications;

namespace Bankapp.Services
{
    class BankService : IBankService
    {

        private readonly List<BankAccount> _accounts = new();
        private readonly List<Transaction> _transactions = [];


        public void CreateAccount(string name)
        {

            int accNo = _accounts.Count + 1;
            _accounts.Add(new BankAccount(accNo, name));

        }

public event Notify OnTransaction;

        public void Deposit(int accNo, decimal amount)
        {
            var acc = FindAccount(accNo);
            acc.Deposit(amount);
           OnTransaction?.Invoke("Deposited");
        }

        public void WithDraw(int accNo, decimal amount)
        {
            var acc = FindAccount(accNo);
            acc.Withdraw(amount);
           OnTransaction?.Invoke("Withdraw");
        }

        private BankAccount FindAccount(int accNo)
        {
            return _accounts.First(a => a.AccountNumber == accNo);
        }

    }
}