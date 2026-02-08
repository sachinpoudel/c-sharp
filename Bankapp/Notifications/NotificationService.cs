namespace Bankapp.Notifications
{
    public delegate void Notify(string msg);
   public class NotificationService
    {
        public void Send(string msg)
        {
            Console.WriteLine("Notify" + msg);
        }

    }
}