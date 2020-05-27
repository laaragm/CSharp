using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Interfaces.Entities
{
	class Invoice
	{
        public double Tax { get; set; }
        public double BasicPayment { get; set; }

        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
