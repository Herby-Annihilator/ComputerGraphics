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

		public Parameters(T xParameter, T yParameter, T zParameter)
		{
			XParameter = xParameter;
			YParameter = yParameter;
			ZParameter = zParameter;
		}

		public Parameters()
		{
			XParameter = default(T);
			YParameter = default(T);
			ZParameter = default(T);
		}

		public void FillBy(T value)
		{
			XParameter = value;
			YParameter = value;
			ZParameter = value;
		}
	}
}
