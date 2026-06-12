namespace MOVIETICKETBOOKINGSYSTEM.Models;

public class Customer : BaseEntity
{
    public string CustomerName { get; set; } = "";
    public decimal WalletBalance { get; set; }

    public Customer(int id, string customerName, decimal walletBalance)
    {
        Id = id;
        CustomerName = customerName;
        WalletBalance = walletBalance;
    }
}