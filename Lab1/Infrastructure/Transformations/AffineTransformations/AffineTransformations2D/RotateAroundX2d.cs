using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Transformations.AffineTransformations.Base;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations2D
{
	class RotateAroundX2d : AffineTransformation<double>, ITransformation<double>
	{
		public override Matrix<double> GetTransformation(Parameters<double> parameters)
		{
			if (matrix == null)
				matrix = CreateMatrix.DiagonalIdentity<double>(3, 3);
			matrix[0, 0] = Math.Cos(parameters.XParameter);
			matrix[0, 1] = -Math.Sin(parameters.XParameter);
			matrix[1, 0] = Math.Sin(parameters.XParameter);
			matrix[1, 1] = Math.Cos(parameters.XParameter);
			return matrix;
		}
	}
}
