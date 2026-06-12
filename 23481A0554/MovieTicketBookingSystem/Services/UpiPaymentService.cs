namespace MOVIETICKETBOOKINGSYSTEM.Services;
using MOVIETICKETBOOKINGSYSTEM.Interfaces;


public class UpiPaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"UPI Payment Sucessful : ₹{amount}");
    }
}