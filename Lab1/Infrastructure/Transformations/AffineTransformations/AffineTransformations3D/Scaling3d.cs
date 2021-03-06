using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Transformations.AffineTransformations.Base;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations3D
{
	public class Scaling3d<T> : AffineTransformation<T>, ITransformation<T> where T : struct, IEquatable<T>, IFormattable
	{
		public override Matrix<T> GetTransformation(Parameters<T> parameters)
		{
			if (matrix == null)
				matrix = CreateMatrix.DenseIdentity<T>(4, 4);
			matrix[0, 0] = parameters.XParameter;
			matrix[1, 1] = parameters.YParameter;
			matrix[2, 2] = parameters.ZParameter;
			return matrix;
		}
	}
}
