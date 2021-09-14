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
			ITransformation<double> xRotate = new RotateAroundX3d();
			ITransformation<double> yRotate = new RotateAroundY3d();
			_matrix = xRotate.GetTransformation(parameters) * yRotate.GetTransformation(parameters);
			return _matrix;
		}
	}
}
