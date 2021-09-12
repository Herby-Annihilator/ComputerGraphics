using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Transformations.AffineTransformations.Base;
using System;
using MathNet.Numerics.LinearAlgebra;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations2D
{
	public class ParallelTransfer2d<T> : AffineTransformation<T>, ITransformation<T> where T : struct, IEquatable<T>, IFormattable
	{
		public override Matrix<T> GetTransformation(Parameters<T> parameters)
		{
			if (matrix == null)
				matrix = CreateMatrix.DiagonalIdentity<T>(3, 3);
			matrix[0, 2] = parameters.XParameter;
			matrix[1, 2] = parameters.YParameter;
			return matrix;
		}
	}
}
