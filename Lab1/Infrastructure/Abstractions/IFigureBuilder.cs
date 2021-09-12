using Lab1.Infrastructure.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Abstractions
{
	public interface IFigureBuilder<T> where T: struct, IEquatable<T>, IFormattable
	{
		Figure<T> Build();
	}
}
