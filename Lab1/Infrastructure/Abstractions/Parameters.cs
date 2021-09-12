using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Abstractions
{
	public class Parameters<T>
	{
		public T XParameter { get; set; }
		public T YParameter { get; set; }
		public T ZParameter { get; set; }
	}
}
