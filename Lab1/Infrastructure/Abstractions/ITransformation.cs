using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace Lab1.Infrastructure.Abstractions
{
	public interface ITransformation<T> where T: struct, IEquatable<T>, IFormattable
	{
		Matrix<T> GetTransformation(Parameters<T> parameters);
	}
}
