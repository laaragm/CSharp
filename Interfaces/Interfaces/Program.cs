using Interfaces.Entities;
using Interfaces.Services;
using System;
using System.Globalization;

namespace Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            VehicleRentalCalculator rentalService = new VehicleRentalCalculator(hour, day, new BrazilTaxCalculator());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("Invoice:");
            Console.WriteLine(carRental.Invoice);
        }
	}
}
