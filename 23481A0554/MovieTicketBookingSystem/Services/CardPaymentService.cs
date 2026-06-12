namespace MOVIETICKETBOOKINGSYSTEM.Services;
using MOVIETICKETBOOKINGSYSTEM.Interfaces;



public class CardPaymentService : IPaymentService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine(
            $"Card Payment Successful : ₹{amount}");
    }
}