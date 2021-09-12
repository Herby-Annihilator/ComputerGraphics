using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Transformations.AffineTransformations.Base;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations3D
{
	public class RotateAroundY3d : AffineTransformation<double>, ITransformation<double>
	{
		public override Matrix<double> GetTransformation(Parameters<double> parameters)
		{
			if (matrix == null)
				matrix = CreateMatrix.DenseIdentity<double>(4, 4);
			matrix[0, 0] = Math.Cos(parameters.YParameter);
			matrix[0, 2] = -Math.Sin(parameters.YParameter);
			matrix[2, 0] = Math.Sin(parameters.YParameter);
			matrix[2, 2] = Math.Cos(parameters.YParameter);
			return matrix;
		}
	}
}
