using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Extensions;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1.Infrastructure.Figures
{
	public class Point3d : DoubleFigure3d
	{
		private int _width;
		public override Figure<double> Clone()
		{
			Point3d result = new Point3d(0, 0, 0, _width);
			result.Vertexes = CreateMatrix.DenseOfMatrix(Vertexes);
			result.Edges = Edges.CloneMatrix();
			return result;
		}

		public Point3d(double centerX, double centerY, double centerZ, int width)  // 3д точка - это просто столбец с четырьмя строками
		{
			_width = width;
			Vertexes = CreateMatrix.Dense<double>(4, 1);
			Vertexes[0, 0] = centerX;
			Vertexes[1, 0] = centerY;
			Vertexes[2, 0] = centerZ;
			Vertexes[3, 0] = 1;
			Edges = new int[0][];
		}

		public override void Draw(Graphics graphics, PointF startPoint)
		{
			Pen.Width = _width;
			Pen.Color = Color.Blue;
			float centerX = (float)Vertexes[0, 0];
			float centerY = (float)Vertexes[1, 0];
			graphics.DrawEllipse(Pen, centerX + startPoint.X - 3, centerY + startPoint.Y - 3, 6, 6);
		}

		public override double Perimeter() => 0;

		public override Vector<double> CenterOfMass() => CreateVector.DenseOfArray(new double[] { Vertexes[0, 0], Vertexes[1, 0], Vertexes[0, 2] });
	}
}
