using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Transformations.AffineTransformations.Base;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations3D
{
	public class RotateAroundZ3d : AffineTransformation<double>, ITransformation<double>
	{
		public override Matrix<double> GetTransformation(Parameters<double> parameters)
		{
			if (matrix == null)
				matrix = CreateMatrix.DenseIdentity<double>(4, 4);
			matrix[0, 0] = Math.Cos(parameters.ZParameter);
			matrix[0, 1] = -Math.Sin(parameters.ZParameter);
			matrix[1, 0] = Math.Sin(parameters.ZParameter);
			matrix[1, 1] = Math.Cos(parameters.ZParameter);
			return matrix;
		}
	}
}
