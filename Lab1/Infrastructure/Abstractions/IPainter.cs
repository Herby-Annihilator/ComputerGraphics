using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1.Infrastructure.Abstractions
{
	public interface IPainter<T> where T: struct, IEquatable<T>, IFormattable
	{
		void Draw(Figure<T> figure, Matrix<T> finalTranformationMatrix, Graphics graphics);
		void Draw(Figure<T> figure, List<Matrix<T>> tranfromationMatrices, Graphics graphics);
		void Draw(Figure<T> figure, ITransformation<T> finalTransformation, Parameters<T> parameter, Graphics graphics);
		void Draw(Figure<T> figure, List<ITransformation<T>> transformations, List<Parameters<T>> parameters, Graphics graphics);
	}
}
