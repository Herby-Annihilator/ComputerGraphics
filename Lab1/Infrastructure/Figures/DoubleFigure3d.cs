using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Transformations.Projection;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1.Infrastructure.Figures
{
	public abstract class DoubleFigure3d : Figure<double>
	{
		protected AxonometricProjection _projection = new AxonometricProjection();
		protected Parameters<double> _params = new Parameters<double>();
		protected override Vector<double> CenterPointRadiusVector(double x1, double x2, double y1, double y2, double z1, double z2) =>
			CreateVector.DenseOfArray(new double[] { (x1 + x2) / 2, (y1 + y2) / 2, (z1 + z2) / 2 });
		protected override double EdgeLength(Vector<double> firstPoint, Vector<double> secondPoint) =>
			Math.Sqrt(Math.Pow((firstPoint[0] - secondPoint[0]), 2)
				+ Math.Pow((firstPoint[1] - secondPoint[1]), 2) 
				+ Math.Pow((firstPoint[2] - secondPoint[2]), 2))
			;

		protected override Matrix<double> ToProection()
		{
			Matrix<double> result = Vertexes.Clone();
			_params.XParameter = 150 * (Math.PI / 180);
			return _projection.GetTransformation(_params).Transpose() * result;
		}
	}
}
