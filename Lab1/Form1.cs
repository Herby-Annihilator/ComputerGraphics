﻿using Lab1.Infrastructure.Abstractions;
using Lab1.Infrastructure.FigureBuilders;
using Lab1.Infrastructure.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Infrastructure.Transformations.Projection;
using Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations3D;
using MathNet.Numerics.LinearAlgebra;

namespace Lab1
{
	public partial class Form1 : Form
	{
		private IFigureBuilder<double> _symbolBuilder;
		private Figure<double> _figure;
		private CoordSystem _coords = new CoordSystem(0, 0, 0, 25, 25, 25);
		private Figure<double> _point3d = new Point3d(0, 0, 0, 5);
		private PointF _coordsStartPoint = new PointF(0, 0);

		private GarbageContainer _container = new GarbageContainer();

		public Form1()
		{
			InitializeComponent();
			_symbolBuilder = new FigureFromFileBuilder("D:\\GarbageCan\\Projects\\VisualStudio\\Semester_7\\ComputerGraphics\\bin\\Debug\\netcoreapp3.1\\figure.txt");
			_figure = _symbolBuilder.Build();
			SystemToStartCondition();
			this.MouseWheel += Form1_MouseWheel;
			this.KeyDown += Form1_KeyDown;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			Parameters<double> parameter;
			switch (e.KeyCode)
			{
				case Keys.Up:
					parameter = _container.TransferParameters;
					parameter.YParameter = -10;
					MoveSystem(parameter);
					break;
				case Keys.Down:
					parameter = _container.TransferParameters;
					parameter.YParameter = 10;
					MoveSystem(parameter);
					break;
				case Keys.Left:
					parameter = _container.TransferParameters;
					parameter.XParameter = -10;
					MoveSystem(parameter);
					break;
				case Keys.Right:
					parameter = _container.TransferParameters;
					parameter.XParameter = 10;
					MoveSystem(parameter);
					break;
				case Keys.D1:
					parameter = _container.RotationParameters;
					parameter.XParameter = ToRadians(5);
					RotateSystemAroundX(parameter);
					break;
				case Keys.D2:
					parameter = _container.RotationParameters;
					parameter.YParameter = ToRadians(5);
					RotateSystemAroundY(parameter);
					break;
				case Keys.D3:
					parameter = _container.RotationParameters;
					parameter.ZParameter = ToRadians(5);
					RotateSystemAroundZ(parameter);
					break;
				case Keys.Escape:
					SystemToStartCondition();
					break;
				case Keys.W:
					parameter = _container.TransferParameters;
					parameter.YParameter = 10;
					MoveFigure(_point3d, parameter);
					MoveFigure(_figure, parameter);
					break;
				case Keys.S:
					parameter = _container.TransferParameters;
					parameter.YParameter = -10;
					MoveFigure(_point3d, parameter);
					MoveFigure(_figure, parameter);
					break;
				case Keys.D:
					parameter = _container.TransferParameters;
					parameter.XParameter = 10;
					MoveFigure(_point3d, parameter);
					MoveFigure(_figure, parameter);
					break;
				case Keys.A:
					parameter = _container.TransferParameters;
					parameter.XParameter = -10;
					MoveFigure(_point3d, parameter);
					MoveFigure(_figure, parameter);
					break;
				case Keys.Z:
					parameter = _container.RotationParameters;
					parameter.XParameter = ToRadians(5);
					TransformFigure(_figure, _container.RotateAroundX3D, parameter);
					TransformFigure(_point3d, _container.RotateAroundX3D, parameter);
					break;
				case Keys.X:
					parameter = _container.RotationParameters;
					parameter.YParameter = ToRadians(5);
					TransformFigure(_figure, _container.RotateAroundY3D, parameter);
					TransformFigure(_point3d, _container.RotateAroundY3D, parameter);
					break;
				case Keys.C:
					parameter = _container.RotationParameters;
					parameter.ZParameter = ToRadians(5);
					TransformFigure(_figure, _container.RotateAroundZ3D, parameter);
					TransformFigure(_point3d, _container.RotateAroundZ3D, parameter);
					break;
				default:
					break;
			}
		}

		private void Form1_MouseWheel(object sender, MouseEventArgs e)
		{
			Parameters<double> parameters = _container.ScalingParameters;
			parameters.XParameter = e.Delta > 0 ? (e.Delta / 60.0) : (-1 / (e.Delta / 60.0));
			parameters.YParameter = e.Delta > 0 ? (e.Delta / 60.0) : (-1 / (e.Delta / 60.0));
			parameters.ZParameter = e.Delta > 0 ? (e.Delta / 60.0) : (-1 / (e.Delta / 60.0));
			ScaleSystem(parameters);
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{			
			canvas.Invalidate();
		}

		private void canvas_Paint(object sender, PaintEventArgs e)
		{
			_figure.Draw(e.Graphics, _coordsStartPoint);
			_coords.Draw(e.Graphics, _coordsStartPoint);
			_point3d.Draw(e.Graphics, _coordsStartPoint);
			e.Graphics.DrawEllipse(new Pen(Color.Red, 5), _coordsStartPoint.X - 5, _coordsStartPoint.Y - 5, 10, 10);
			
		}


		private void SystemToStartCondition()
		{
			Parameters<double> scalingParameters = new Parameters<double>(30, 30, 30);
			Matrix<double> finalTransformation =
				_container.Scaling3D.GetTransformation(scalingParameters);
			_figure = _symbolBuilder.Build();
			ApplyTransformation(_figure, finalTransformation);
			_coords = new CoordSystem(0, 0, 0, 25, 25, 25);
			ApplyTransformation(_coords, finalTransformation);
			_coordsStartPoint.X = 0;
			_coordsStartPoint.Y = 0;
			canvas.Invalidate();
		}

		private double ToRadians(double value) => value * (Math.PI / 180);

		private void ApplyTransformation(Figure<double> figure, Matrix<double> finalTransformationMatrix)
		{
			figure.Vertexes = finalTransformationMatrix * figure.Vertexes;
		}

		private void MoveSystem(Parameters<double> parameters)
		{
			Matrix<double> matrix = _container.ParallelTransfer3D.GetTransformation(parameters);

			_coordsStartPoint.X += (float)parameters.XParameter;
			labelXTransfer.Text = _coordsStartPoint.X.ToString();

			_coordsStartPoint.Y += (float)parameters.YParameter;
			labelYTransfer.Text = _coordsStartPoint.Y.ToString();

			//ApplyTransformation(_figure, matrix);
			//ApplyTransformation(_coords, matrix);
			canvas.Invalidate();
		}

		private void ScaleSystem(Parameters<double> scaleParameter)
		{
			Matrix<double> matrix = _container.Scaling3D.GetTransformation(scaleParameter);
			ApplyTransformation(_figure, matrix);
			ApplyTransformation(_coords, matrix);
			ApplyTransformation(_point3d, matrix);
			canvas.Invalidate();
		}

		private void RotateSystemAroundX(Parameters<double> parameters)
		{
			Matrix<double> matrix = _container.RotateAroundX3D.GetTransformation(parameters);
			ApplyTransformation(_figure, matrix);
			ApplyTransformation(_coords, matrix);
			ApplyTransformation(_point3d, matrix);
			canvas.Invalidate();
		}

		private void RotateSystemAroundY(Parameters<double> parameters)
		{
			Matrix<double> matrix = _container.RotateAroundY3D.GetTransformation(parameters);
			ApplyTransformation(_figure, matrix);
			ApplyTransformation(_coords, matrix);
			ApplyTransformation(_point3d, matrix);
			canvas.Invalidate();
		}

		private void RotateSystemAroundZ(Parameters<double> parameters)
		{
			Matrix<double> matrix = _container.RotateAroundZ3D.GetTransformation(parameters);
			ApplyTransformation(_figure, matrix);
			ApplyTransformation(_coords, matrix);
			ApplyTransformation(_point3d, matrix);
			canvas.Invalidate();
		}

		private void MoveFigure(Figure<double> figure, Parameters<double> parameter)
		{
			Matrix<double> matrix = _container.ParallelTransfer3D.GetTransformation(parameter);
			ApplyTransformation(figure, matrix);
			canvas.Invalidate();
		}

		private void TransformFigure(Figure<double> figure, ITransformation<double> transformation, Parameters<double> parameters)
		{
			Matrix<double> matrix = transformation.GetTransformation(parameters);
			ApplyTransformation(figure, matrix);
			canvas.Invalidate();
		}
	}
}
