using Interfaces2.Abstractions;
using Interfaces2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2.Services
{
	class PaypalCalculator : IOnlinePaymentService
	{
		private const double FeeRate = 0.02;
		private const double MontlyInterest = 0.01;
		public double Interest(double amount, int months)
		{
			return MontlyInterest * amount * months;
		}

		public double PaymentFee(double amount)
		{
			return amount * FeeRate;
		}
	}
}
