using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace Lab1.Infrastructure.Figures
{
	public abstract class Figure<T> where T : struct, IEquatable<T>, IFormattable
	{
		protected Matrix<T> _vertexes;
		protected int[][] _edges;
		protected Pen _pen = new Pen(Color.Black);

		public virtual Matrix<T> Vertexes { get => _vertexes; set => _vertexes = value; }
		public virtual int[][] Edges { get => _edges; set => _edges = value; }
		public virtual Pen Pen { get => _pen; set => _pen = value; }

		public abstract void DrawFigure(Graphics graphics);
	}
}
