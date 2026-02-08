namespace Bankapp.Models
{
    public class BankAccount
    {
        public int AccountNumber { get; }
        public string HolderName { get; }
        public decimal Balance { get; private set; }

        public bool IsActive { get; private set; }




        public BankAccount(int accountNumber, string holderName)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = 0;
            IsActive = true;
        }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("cant withdraw money you ");
            }
            Balance -= amount;
        }


    }
}