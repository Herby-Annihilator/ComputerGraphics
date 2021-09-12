using Lab1.Infrastructure.Abstractions;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Transformations.AffineTransformations.Base
{
	public abstract class AffineTransformation<T> : ITransformation<T> where T : struct, IEquatable<T>, IFormattable
	{
		protected Matrix<T> matrix;
		public abstract Matrix<T> GetTransformation(Parameters<T> parameters);
	}
}
