using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Extensions
{
	static class StringExtensions
	{
		public static string Cut(this string str, int count)
		{
			if (str.Length <= count)
			{
				return str;
			}
				
			return str.Substring(0, count) + "...";
		}
	}
}
