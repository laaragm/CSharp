using Interfaces2.Abstractions;
using Interfaces2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2.Services
{
	class ContractCalculator 
	{
		public IOnlinePaymentService OnlinePaymentService;

		public ContractCalculator(IOnlinePaymentService onlinePaymentService)
		{
			OnlinePaymentService = onlinePaymentService;
		}
		public void ProcessContract(Contract contract, int months)
		{
			double baseValue = contract.TotalValue / months;

			for (int i = 1; i <= months; i++)
			{
				DateTime date = contract.Date.AddMonths(i);
				double updatedValue = baseValue + OnlinePaymentService.Interest(baseValue, i);
				double fullValue = updatedValue + OnlinePaymentService.PaymentFee(updatedValue);
				contract.AddInstallment(new Installment(date, fullValue));
			}
		}

	}
}
