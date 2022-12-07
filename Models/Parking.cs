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
    }
}