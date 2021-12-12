using Lab1.Infrastructure.Abstractions;
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
using System.Drawing.Drawing2D;

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
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.UpdateStyles();
			_symbolBuilder = new FigureFromFileBuilder("D:\\GarbageCan\\Projects\\ComputerGraphics\\figure.txt");
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
					parameter.YParameter = -10;
					MoveFigure(_point3d, parameter);
					MoveFigure(_figure, parameter);
					break;
				case Keys.S:
					parameter = _container.TransferParameters;
					parameter.YParameter = 10;
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
				case Keys.F1:
					parameter = _container.TransferParameters;
					parameter.ZParameter = -10;
					MoveFigure(_point3d, parameter);
					MoveFigure(_figure, parameter);
					break;
				case Keys.F2:
					parameter = _container.TransferParameters;
					parameter.ZParameter = 10;
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
				case Keys.F3:
					parameter = _container.ScalingParameters;
					parameter.XParameter = 2;
					parameter.YParameter = 2;
					parameter.ZParameter = 2;
					TransformFigure(_figure, _container.Scaling3D, parameter);
					TransformFigure(_point3d, _container.Scaling3D, parameter);
					break;
				case Keys.F4:
					parameter = _container.ScalingParameters;
					parameter.XParameter = 0.5;
					parameter.YParameter = 0.5;
					parameter.ZParameter = 0.5;
					TransformFigure(_figure, _container.Scaling3D, parameter);
					TransformFigure(_point3d, _container.Scaling3D, parameter);
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
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.CompositingQuality = CompositingQuality.HighQuality;

			g.DrawEllipse(new Pen(Color.Red, 6), _coordsStartPoint.X - 3, _coordsStartPoint.Y - 3, 6, 6);
			_figure.Draw(g, _coordsStartPoint);
			_coords.Draw(g, _coordsStartPoint);
			_point3d.Draw(g, _coordsStartPoint);
		}

		protected override CreateParams CreateParams
		{
			get
			{
				var cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;    // WS_EX_COMPOSITED
				return cp;
			}
		}


		private void SystemToStartCondition()
		{
			_figure = _symbolBuilder.Build();			
			_coords = new CoordSystem(0, 0, 0, 25, 25, 25);
			_point3d = new Point3d(0, 0, 0, 5);
			_coordsStartPoint.X = 500;
			_coordsStartPoint.Y = 500;
			Parameters<double> parameters = new Parameters<double>(30, 30, 30);
			Matrix<double> finalTransformation =
				_container.Scaling3D.GetTransformation(parameters);
			ApplyTransformation(_figure, finalTransformation);
			ApplyTransformation(_coords, finalTransformation);

			parameters = _container.RotationParameters;
			parameters.XParameter = ToRadians(180);
			parameters.YParameter = ToRadians(-45);

			finalTransformation = _container.RotateAroundX3D.GetTransformation(parameters);
			//finalTransformation *= _container.RotateAroundY3D.GetTransformation(parameters);

			ApplyTransformation(_figure, finalTransformation);
			ApplyTransformation(_coords, finalTransformation);
			ApplyTransformation(_point3d, finalTransformation);
			canvas.Refresh();
		}

		private double ToRadians(double value) => value * (Math.PI / 180);

		private void ApplyTransformation(Figure<double> figure, Matrix<double> finalTransformationMatrix)
		{
			figure.Vertexes = finalTransformationMatrix * figure.Vertexes;
		}

		private void MoveSystem(Parameters<double> parameters)
		{
			_coordsStartPoint.X += (float)parameters.XParameter;
			_coordsStartPoint.Y += (float)parameters.YParameter;
			labelXTransfer.Text = _coordsStartPoint.X.ToString();
			labelYTransfer.Text = _coordsStartPoint.Y.ToString();

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
			canvas.Refresh();
		}

		private void RotateSystemAroundY(Parameters<double> parameters)
		{
			Matrix<double> matrix = _container.RotateAroundY3D.GetTransformation(parameters);
			ApplyTransformation(_figure, matrix);
			ApplyTransformation(_coords, matrix);
			ApplyTransformation(_point3d, matrix);
			canvas.Refresh();
		}

		private void RotateSystemAroundZ(Parameters<double> parameters)
		{
			Matrix<double> matrix = _container.RotateAroundZ3D.GetTransformation(parameters);
			ApplyTransformation(_figure, matrix);
			ApplyTransformation(_coords, matrix);
			ApplyTransformation(_point3d, matrix);
			canvas.Refresh();
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
