using parking_lot_system.Models;

decimal priceInitial = 0m;
decimal pricePerHour = 0m;
string option = string.Empty;
bool showMenu = true;

Console.WriteLine("Welcome to the parking system!\n" +
                  "Enter the starting price:");
priceInitial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now enter the price per hour:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking parking = new Parking(priceInitial, pricePerHour);

while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Type your option:");
    Console.WriteLine("1 - Register vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Exit");

    switch (Console.ReadLine())
    {
        case "1":
            parking.AddVehicle();
            break;
        
        case "2":
            parking.RemoveVehicle();
            break;
        
        case "3":
            parking.ListVehicles();
            break;
        
        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    Console.WriteLine("Press any key to proceed");
    Console.ReadLine();
}

Console.WriteLine("The program has ended");