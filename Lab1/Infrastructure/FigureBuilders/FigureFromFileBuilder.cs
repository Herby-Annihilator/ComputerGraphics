using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.Figures;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Lab1.Infrastructure.FigureBuilders
{
	public class FigureFromFileBuilder : IFigureBuilder<double>
	{
		protected string fileName;
		public virtual string FileName { get => fileName; set => fileName = value; }
		private const string VERTEXES_TAG = "[vertexes]";
		private const string END_VERTEXES_TAG = "[end_vertexes]";
		private const string EDGES_TAG = "[edges]";
		private const string END_EDGES_TAG = "[end_edges]";

		public FigureFromFileBuilder(string fileName)
		{
			FileName = fileName;
		}
		public Figure<double> Build()
		{
			StreamReader reader = new StreamReader(FileName);
			List<Vertex> vertexes = new List<Vertex>();			
			List<Edge> edges = new List<Edge>();
			string buffer;
			while ((buffer = reader.ReadLine()) != null)
			{
				if (buffer == VERTEXES_TAG)
				{
					while(buffer != END_VERTEXES_TAG)
					{
						buffer = reader.ReadLine();
						if (!string.IsNullOrWhiteSpace(buffer))
						{
							vertexes.Add(StrToVertex(buffer));
						}
					}
				}
				if (buffer == EDGES_TAG)
				{
					while (buffer != END_EDGES_TAG)
					{
						buffer = reader.ReadLine();
						if (!string.IsNullOrWhiteSpace(buffer))
						{
							edges.Add(StrToEdge(buffer));
						}
					}
				}
			}
			reader.Close();
			vertexes.Sort((first, second) =>
			{
				if (first.ID > second.ID) return 1;
				if (first.ID < second.ID) return -1;
				return 0;
			});
			edges.Sort((first, second) =>
			{
				if (first.ID > second.ID) return 1;
				if (first.ID < second.ID) return -1;
				return 0;
			});
			Figure<double> figure = new Figure<double>();
			double[][] vertexesMatrix = new double[vertexes.Count][];
			for (int i = 0; i < vertexes.Count; i++)
			{
				vertexesMatrix[i] = vertexes[i].ToDoubleArray();
			}
			int[][] edgesMatrix = new int[edges.Count][];
			for (int i = 0; i < edges.Count; i++)
			{
				edgesMatrix[i] = edges[i].ToIntArray();
			}
			figure.Vertexes = DenseMatrix.OfRowArrays(vertexesMatrix);
			figure.Edges = edgesMatrix;
			return figure;
		}

		private Vertex StrToVertex(string str)
		{
			string[] parts = str.Split("=", StringSplitOptions.RemoveEmptyEntries);
			Vertex vertex = new Vertex();
			string[] numbers = parts[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
			vertex.ID = Convert.ToInt32(parts[0]);
			vertex.X = Convert.ToDouble(numbers[0].Replace(".", ","));
			vertex.Y = Convert.ToDouble(numbers[1].Replace(".", ","));
			vertex.Z = Convert.ToDouble(numbers[2].Replace(".", ","));
			return vertex;
		}

		private Edge StrToEdge(string str)
		{
			string[] parts = str.Split("=", StringSplitOptions.RemoveEmptyEntries);
			Edge edge = new Edge();
			edge.ID = Convert.ToInt32(parts[0]);
			string[] numbers = parts[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
			edge.FirstVertexID = Convert.ToInt32(numbers[0]);
			edge.SecondVertexID = Convert.ToInt32(numbers[1]);
			return edge;
		}
	}

	class Vertex
	{
		public int ID { get; set; }
		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }

		public double[] ToDoubleArray()
		{
			double[] result = new double[3];
			result[0] = X;
			result[1] = Y;
			result[2] = Z;
			return result;
		}
	}

	class Edge
	{
		public int ID { get; set; }
		public int FirstVertexID { get; set; }
		public int SecondVertexID { get; set; }

		public int[] ToIntArray()
		{
			int[] result = new int[2];
			result[0] = FirstVertexID;
			result[1] = SecondVertexID;
			return result;
		}
	}
}
