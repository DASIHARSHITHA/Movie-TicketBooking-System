using System;

namespace MOVIETICKETBOOKINGSYSTEM;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("MOVIE TICKET BOOKING SYSTEM");
            Console.WriteLine("========================================");
            Console.WriteLine("1. View Movies");
            Console.WriteLine("2. View Customers");
            Console.WriteLine("3. Book Ticket");
            Console.WriteLine("4. View Booking History");
            Console.WriteLine("5. Exit");

            Console.Write("\nChoose Option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewMovies();
                    break;

                case 2:
                    ViewCustomers();
                    break;

                case 3:
                BookTicket();
                break;

                case 4:
                    Console.WriteLine("\nBooking History Module Coming Next...");
                    break;

                case 5:
                    Console.WriteLine("\nApplication Closed");
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice");
                    break;
            }
        }
    }

    static void ViewMovies()
    {
        string[] movies = File.ReadAllLines("Data/movies.txt");

        Console.WriteLine("\n========== AVAILABLE MOVIES ==========");

        foreach (string movie in movies)
        {
            string[] data = movie.Split('|');

            Console.WriteLine($"\nMovie Id : {data[0]}");
            Console.WriteLine($"Movie Name : {data[1]}");
            Console.WriteLine($"Language : {data[2]}");
            Console.WriteLine($"Duration : {data[3]} Minutes");
            Console.WriteLine($"Ticket Price : ₹{data[4]}");
        }
    }

    static void ViewCustomers()
    {
        string[] customers = File.ReadAllLines("Data/customers.txt");

        Console.WriteLine("\n========== AVAILABLE CUSTOMERS ==========");

        foreach (string customer in customers)
        {
            string[] data = customer.Split('|');

            Console.WriteLine($"\nCustomer Id : {data[0]}");
            Console.WriteLine($"Customer Name : {data[1]}");
            Console.WriteLine($"Wallet Balance : ₹{data[2]}");
        }
    }
    static void BookTicket()
{
    Console.WriteLine("\n===== BOOK TICKET =====");

    Console.WriteLine("\nAvailable Customers");
    ViewCustomers();

    Console.Write("\nEnter Customer Id: ");
    int customerId = Convert.ToInt32(Console.ReadLine());
    if (customerId < 1 || customerId > 4)
{
    Console.WriteLine("Invalid Customer");
    return;
}

    Console.WriteLine("\nAvailable Movies");
    ViewMovies();

    Console.Write("\nEnter Movie Id: ");
    int movieId = Convert.ToInt32(Console.ReadLine());
    if (movieId < 1 || movieId > 3)
{
    Console.WriteLine("Invalid Movie");
    return;
}

    Console.WriteLine("\nAvailable Shows");

    string[] shows = File.ReadAllLines("Data/shows.txt");

    foreach (string show in shows)
    {
        string[] data = show.Split('|');

        Console.WriteLine($"Show Id : {data[0]}  Time : {data[3]}");
    }

    Console.Write("\nEnter Show Id: ");
    int showId = Convert.ToInt32(Console.ReadLine());
    if (showId < 1 || showId > 4)
{
    Console.WriteLine("Invalid Show");
    return;
}

    Console.Write("\nEnter Ticket Count: ");
int ticketCount = Convert.ToInt32(Console.ReadLine());
if (ticketCount <= 0)
{
    Console.WriteLine("Invalid Ticket Count");
    return;
}

decimal ticketPrice = 200;
decimal amount = ticketPrice * ticketCount;

decimal walletBalance = 5000;

Console.WriteLine($"\nCustomer Balance : ₹{walletBalance}");
Console.WriteLine($"Required Amount : ₹{amount}");

if (walletBalance < amount)
{
    Console.WriteLine("\nInsufficient Balance");
    Console.WriteLine("Booking Failed");
    return;
}

walletBalance = walletBalance - amount;

Console.WriteLine($"Remaining Balance : ₹{walletBalance}");

Console.WriteLine($"\nTicket Price : ₹{ticketPrice}");
Console.WriteLine($"Ticket Count : {ticketCount}");
Console.WriteLine($"Total Amount : ₹{amount}");

Console.WriteLine("\nSelect Payment Method");
Console.WriteLine("1. UPI");
Console.WriteLine("2. Card");

Console.Write("Choose Option : ");
int paymentChoice = Convert.ToInt32(Console.ReadLine());

if (paymentChoice == 1)
{
    Console.WriteLine($"UPI Payment Successful : ₹{amount}");
}
else if (paymentChoice == 2)
{
    Console.WriteLine($"Card Payment Successful : ₹{amount}");
}

Console.WriteLine("\nBooking Completed Successfully");
}
}