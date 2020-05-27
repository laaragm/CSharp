using Interfaces2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2.Abstractions
{
	public interface IOnlinePaymentService
	{
		double PaymentFee(double amount);
		double Interest(double amount, int months);
	}
}
