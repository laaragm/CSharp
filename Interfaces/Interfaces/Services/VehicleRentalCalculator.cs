using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.Abstractions;
using Interfaces.Entities;

namespace Interfaces.Services
{
	class VehicleRentalCalculator 
	{
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService TaxService;

        //Inversão de controle (retirar da classe a responsabilidade de instanciar suas dependências)
        //por meio de Injeção de Dependência (uma forma de realizar a inversão controle - um componente
        //externo instancia a dependência, que é então injetada no objeto pai).
        //DI pode ser implementada de várias formas: construtor, framework/container, objeto de
        //instanciação (builder/factory).
        //A classe VehicleRentalCalculator não instancia a dependência dela, e sim recebe esse objeto 
        //instanciado (ITaxService taxService) e atribui (TaxService).
        public VehicleRentalCalculator(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            TaxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
