namespace MOVIETICKETBOOKINGSYSTEM.Services;
using System.Transactions;
using MOVIETICKETBOOKINGSYSTEM.Interfaces;


public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"email Sent: {message}");
    }
}