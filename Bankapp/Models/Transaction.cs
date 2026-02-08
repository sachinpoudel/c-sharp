 namespace Bankapp.Models
{
    class Transaction
    {
        public DateTime Date {get;} = DateTime.Now;
        public decimal Amount {get;}
        public string Type {get;}
        public Transaction(decimal amount , string type)
        {
            Amount = amount;
            Type = type;
        }
    }
}