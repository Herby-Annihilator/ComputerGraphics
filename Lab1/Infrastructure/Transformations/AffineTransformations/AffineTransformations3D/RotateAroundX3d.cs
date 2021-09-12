using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Transformations.AffineTransformations.Base;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations3D
{
	public class RotateAroundX3d : AffineTransformation<double>, ITransformation<double>
	{
		public override Matrix<double> GetTransformation(Parameters<double> parameters)
		{
			if (matrix == null)
				matrix = CreateMatrix.DenseIdentity<double>(4,4);
			matrix[1, 1] = Math.Cos(parameters.XParameter);
			matrix[1, 2] = -1 * Math.Sin(parameters.XParameter);
			matrix[2, 1] = Math.Sin(parameters.XParameter);
			matrix[2, 2] = Math.Cos(parameters.XParameter);
			return matrix;
		}
	}
}
