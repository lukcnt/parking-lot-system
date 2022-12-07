using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parking_lot_system.Models
{
    public class Parking
    {
        private decimal priceInitial = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal priceInitial, decimal pricePerHour)
        {
            this.priceInitial = priceInitial;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            string licensePlate = "";

            Console.WriteLine("Enter the license plate of the vehicle to park: ");
            licensePlate = Console.ReadLine();
            if (licensePlate.Length < 8)
            {
                Console.WriteLine($"{licensePlate} isn't a valid license plate.");
            }
            else
            {
                vehicles.Add(licensePlate);
            }
        }

        public void RemoveVehicle()
        {
            string licensePlate = "";

            Console.WriteLine("Enter the license plate of the vehicle to remove:");
            licensePlate = Console.ReadLine();

            if (vehicles.Any(item => item.ToUpper() == licensePlate.ToUpper()))
            {
                int hours = 0;
                decimal totalAmount = 0m;

                Console.WriteLine("Enter the amount of hours the vehicle has remained parked:");
                hours = Convert.ToInt32(Console.ReadLine());
                totalAmount = priceInitial + (pricePerHour * hours);

                vehicles.Remove(licensePlate);
                Console.WriteLine($"The vehicle {licensePlate} was removed and total price was: R$ {totalAmount} .");
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle is not parked here. Please make sure you have entered the license plate correctly");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("The parked vehicles are:");

                for (int counter = 0; counter < vehicles.Count; counter++ )
                {
                    Console.WriteLine($"{vehicles[counter]}");
                }
            }
            else
            {
                Console.WriteLine("No vehicles are parked");
            }
        }
    }
}