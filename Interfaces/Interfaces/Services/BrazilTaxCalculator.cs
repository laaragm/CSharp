using Interfaces.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services
{
	class BrazilTaxCalculator : ITaxService
	{
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
         
            return amount * 0.15;
        }
    }
}
