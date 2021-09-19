using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1.Infrastructure.Figures
{
	public class CoordSystem : Symbol
	{
		public CoordSystem(double x, double y, double z, int width, int height, int capacity)
		{
			Vertexes = CreateMatrix.Dense<double>(4, 4);
			Vertexes[0, 0] = x;
			Vertexes[1, 0] = y;
			Vertexes[2, 0] = z;

			Vertexes[0, 1] = x + width;
			Vertexes[1, 1] = y;
			Vertexes[2, 1] = z;

			Vertexes[0, 2] = x;
			Vertexes[1, 2] = y + height;
			Vertexes[2, 2] = z;

			Vertexes[0, 3] = x;
			Vertexes[1, 3] = y;
			Vertexes[2, 3] = z + capacity;
			Vertexes[3, 3] = 1;

			Edges = new int[3][];
			for (int i = 0; i < 3; i++)
			{
				Edges[i] = new int[2];
			}
			Edges[0][0] = 0;
			Edges[0][1] = 1;
			Edges[1][0] = 0;
			Edges[1][1] = 2;
			Edges[2][0] = 0;
			Edges[2][1] = 3;
		}
		public override void Draw(Graphics graphics, PointF startPoint)
		{
			int rows = _edges.GetLength(0);
			int firstVertexIndex, secondVertexIndex;
			double x1, x2, y1, y2;
			Pen.Width = 2;
			for (int i = 0; i < rows; i++)
			{
				firstVertexIndex = Edges[i][0];
				secondVertexIndex = Edges[i][1];
				x1 = Vertexes[0, firstVertexIndex];
				x2 = Vertexes[0, secondVertexIndex];
				y1 = Vertexes[1, firstVertexIndex];
				y2 = Vertexes[1, secondVertexIndex];
				if (i == 0)
					Pen.Color = Color.Blue;
				else if (i == 1)
					Pen.Color = Color.Red;
				else
					Pen.Color = Color.Green;
				graphics.DrawLine(Pen, (float)x1 + startPoint.X,
					(float)y1 + startPoint.Y, (float)x2 + startPoint.X,
					(float)y2 + startPoint.Y);
			}
		}
	}
}
