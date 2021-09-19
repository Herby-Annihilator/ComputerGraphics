using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Extensions;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1.Infrastructure.Figures
{
	public class Symbol : Figure<double>
	{
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
			for (int i = 0; i < rows; i++)
			{
				firstVertexIndex = Edges[i][0];
				secondVertexIndex = Edges[i][1];
				x1 = Vertexes[0, firstVertexIndex];
				x2 = Vertexes[0, secondVertexIndex];
				y1 = Vertexes[1, firstVertexIndex];
				y2 = Vertexes[1, secondVertexIndex];
				graphics.DrawLine(Pen, (float)x1 + startPoint.X,
					(float)y1 + startPoint.Y, (float)x2 + startPoint.X,
					(float)y2 + startPoint.Y);
			}
		}
	}
}
