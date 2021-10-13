using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Extensions;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Lab1.Infrastructure.Transformations.Projection;

namespace Lab1.Infrastructure.Figures
{
	public class Symbol : DoubleFigure3d
	{
		AxonometricProjection _projection = new AxonometricProjection();
		Parameters<double> _params = new Parameters<double>();

		public override Vector<double> CenterOfMass()
		{
			int rows = Edges.GetLength(0);
			Vector<double> firstPoint;
			Vector<double> secondPoint;
			Vector<double> edgeCenter;
			Vector<double> result = CreateVector.Dense<double>(3, 0);
			double x1, x2, y1, y2, z1, z2;
			int firstVertexIndex, secondVertexIndex;
			for (int i = 0; i < rows; i++)
			{
				firstVertexIndex = Edges[i][0];
				secondVertexIndex = Edges[i][1];
				x1 = Vertexes[0, firstVertexIndex];
				x2 = Vertexes[0, secondVertexIndex];
				y1 = Vertexes[1, firstVertexIndex];
				y2 = Vertexes[1, secondVertexIndex];
				z1 = Vertexes[2, firstVertexIndex];
				z2 = Vertexes[2, secondVertexIndex];
				edgeCenter = CenterPointRadiusVector(x1, x2, y1, y2, z1, z2);
				firstPoint = CreateVector.DenseOfArray(new double[] { x1, y1, z1});
				secondPoint = CreateVector.DenseOfArray(new double[] { x2, y2, z2});
				result += edgeCenter * EdgeLength(firstPoint, secondPoint);
			}
			result /= Perimeter();
			return result;
		}

		public override Figure<double> Clone()
		{
			Symbol result = new Symbol();
			result.Vertexes = CreateMatrix.DenseOfMatrix(Vertexes);
			result.Edges = Edges.CloneMatrix();
			return result;
		}

		public override void Draw(Graphics graphics, PointF startPoint)
		{
			int rows = _edges.GetLength(0);
			int firstVertexIndex, secondVertexIndex;
			double x1, x2, y1, y2;
			Matrix<double> toDraw = ToProection();
			for (int i = 0; i < rows; i++)
			{
				firstVertexIndex = Edges[i][0];
				secondVertexIndex = Edges[i][1];
				x1 = toDraw[0, firstVertexIndex];
				x2 = toDraw[0, secondVertexIndex];
				y1 = toDraw[1, firstVertexIndex];
				y2 = toDraw[1, secondVertexIndex];
				graphics.DrawLine(Pen, (float)x1 + startPoint.X,
					(float)y1 + startPoint.Y, (float)x2 + startPoint.X,
					(float)y2 + startPoint.Y);
			}
		}

		public override double Perimeter()
		{
			int rows = Edges.GetLength(0);
			Vector<double> firstPoint;
			Vector<double> secondPoint;
			double x1, x2, y1, y2, z1, z2;
			int firstVertexIndex, secondVertexIndex;
			double sum = 0;
			for (int i = 0; i < rows; i++)
			{
				firstVertexIndex = Edges[i][0];
				secondVertexIndex = Edges[i][1];
				x1 = Vertexes[0, firstVertexIndex];
				x2 = Vertexes[0, secondVertexIndex];
				y1 = Vertexes[1, firstVertexIndex];
				y2 = Vertexes[1, secondVertexIndex];
				z1 = Vertexes[2, firstVertexIndex];
				z2 = Vertexes[2, secondVertexIndex];
				firstPoint = CreateVector.DenseOfArray(new double[] { x1, y1, z1 });
				secondPoint = CreateVector.DenseOfArray(new double[] { x2, y2, z2 });
				sum += EdgeLength(firstPoint, secondPoint);
			}
			return sum;
		}

		private Matrix<double> ToProection()
		{
			Matrix<double> result = Vertexes.Clone();
			_params.XParameter = 30 * (Math.PI / 180);
			return _projection.GetTransformation(_params).Transpose() * result;
		}
	}
}
