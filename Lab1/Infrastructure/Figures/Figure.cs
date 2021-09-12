using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace Lab1.Infrastructure.Figures
{
	public class Figure<T> where T : struct, IEquatable<T>, IFormattable
	{
		private Matrix<T> _vertexes;
		private int[][] _edges;

		public Matrix<T> Vertexes { get => _vertexes; set => _vertexes = value; }
		public int[][] Edges { get => _edges; set => _edges = value; }
	}
}
