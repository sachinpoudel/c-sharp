using Bankapp.Notifications;
using Bankapp.Services;

class Program
{
    static void Main()
    {
        BankService bank = new();
        var notifer = new NotificationService();

        bank.OnTransaction += notifer.Send;

        bank.CreateAccount("SAchin");
        bank.Deposit(1,5000);
        bank.WithDraw(1, 2000);
    }
}