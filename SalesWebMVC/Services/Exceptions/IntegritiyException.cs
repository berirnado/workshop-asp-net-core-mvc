using System;

namespace SalesWebMvc.Services.Exceptions
{
	public class IntegritiyException : ApplicationException
	{
		public IntegritiyException(string message) : base(message) { }
	}
}
