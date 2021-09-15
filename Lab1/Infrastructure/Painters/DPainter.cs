using Lab1.Infrastructure.Abstractions;
using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1.Infrastructure.Painters
{
	public class DPainter : IPainter<double>
	{
		public void Draw(Figure<double> figure, Matrix<double> finalTranformationMatrix, Graphics graphics)
		{
			figure.Vertexes = finalTranformationMatrix * figure.Vertexes;
			figure.Draw(graphics);
		}

		public void Draw(Figure<double> figure, List<Matrix<double>> tranfromationMatrices, Graphics graphics)
		{
			Matrix<double> finalMatrix = CreateMatrix.Dense(4, 4, 1.0);
			foreach (var matrix in tranfromationMatrices)
			{
				finalMatrix *= matrix;
			}
			Draw(figure, finalMatrix, graphics);
		}

		public void Draw(Figure<double> figure, ITransformation<double> finalTransformation, Parameters<double> parameter, Graphics graphics)
		{
			Draw(figure, finalTransformation.GetTransformation(parameter), graphics);
		}

		public void Draw(Figure<double> figure, List<ITransformation<double>> transformations, List<Parameters<double>> parameters, Graphics graphics)
		{
			Matrix<double> finalMatrix = CreateMatrix.Dense(4, 4, 1.0);
			for (int i = 0; i < transformations.Count; i++)
			{
				finalMatrix *= transformations[i].GetTransformation(parameters[i]);
			}
			Draw(figure, finalMatrix, graphics);
		}
	}
}
