using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.Extensions
{
	public static class MatrixExtensions
	{
		public static T[][] CloneMatrix<T>(this T[][] otherMatrix)
		{
			int rows = otherMatrix.GetLength(0);
			T[][] result = new T[rows][];
			for (int i = 0; i < rows; i++)
			{
				result[i] = new T[otherMatrix[i].Length];
				for (int j = 0; j < otherMatrix[i].Length; j++)
				{
					result[i][j] = otherMatrix[i][j];
				}
			}
			return result;
		}
	}
}
