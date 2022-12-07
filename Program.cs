using parking_lot_system.Models;

decimal priceInitial = 0m;
decimal pricePerHour = 0m;

Console.WriteLine("Welcome to the parking system!\n" +
                  "Enter the starting price:");
priceInitial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now enter the price per hour:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());
