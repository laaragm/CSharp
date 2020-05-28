using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionMethods.Extensions
{
	static class DateTimeExtensions
	{
		//Métodos de extensão: São métodos que estendem a funcionalidade de um tipo, sem precisar alterar o
		//código fonte deste tipo, nem herdar desse tipo.
		//Como fazer um extension method?
		// - Criar uma classe estática
		// - Na classe, criar um método estático
		// - O primeiro parâmetro do método deverá ter o prefixo this, seguido da declaração de um parâmetro do
		//	tipo que se deseja estender.Esta será uma referência para o próprio objeto.
		public static string ElapsedTime(this DateTime dateTime)
		{
			TimeSpan duration = DateTime.Now.Subtract(dateTime);

			if (duration.TotalHours < 24.0)
			{
				return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
			}
			
			return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
		}
	}
}
