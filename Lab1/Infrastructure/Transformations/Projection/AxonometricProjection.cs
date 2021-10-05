using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations3D;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Transformations.Projection
{
	public class AxonometricProjection : ITransformation<double>
	{
		private Matrix<double> _matrix;
		public Matrix<double> GetTransformation(Parameters<double> parameters)
		{
			if (_matrix == null)
				_matrix = CreateMatrix.DenseIdentity<double>(4, 4);
			_matrix[2, 0] = -0.5 * Math.Cos(parameters.XParameter);
			_matrix[2, 1] = -0.5 * Math.Sin(parameters.XParameter);			
			_matrix[2, 2] = 0;			
			return _matrix;
		}
	}
}
