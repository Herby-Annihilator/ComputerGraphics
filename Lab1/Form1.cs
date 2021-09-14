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

namespace Lab1
{
	public partial class Form1 : Form
	{
		private IFigureBuilder<double> _builder;
		private Figure<double> _figure;
		public Form1()
		{
			InitializeComponent();
			_builder = new FigureFromFileBuilder("D:\\GarbageCan\\Projects\\VisualStudio\\Semester_7\\ComputerGraphics\\bin\\Debug\\netcoreapp3.1\\figure.txt");
			_figure = _builder.Build();
			FirstFigureInit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{			
			canvas.Invalidate();
		}

		private void FirstFigureInit()
		{
			ITransformation<double> projection = new AxonometricProjection();
			ITransformation<double> transfer = new ParallelTransfer3d<double>();
			ITransformation<double> scaling = new Scaling3d<double>();
			ITransformation<double> rotate = new RotateAroundX3d();
			Parameters<double> xrotateParameter = new Parameters<double>()
			{
				XParameter = 180 * (Math.PI / 180),
				YParameter = 30 * (Math.PI / 180),
				ZParameter = 0
			};
			ITransformation<double> yrotate = new RotateAroundY3d();
			Parameters<double> yrotateParameter = new Parameters<double>()
			{
				XParameter = 0,
				YParameter = 300 * (Math.PI / 180),
				ZParameter = 0
			};
			Parameters<double> scalingParameters = new Parameters<double>()
			{
				XParameter = 30,
				YParameter = 30,
				ZParameter = 30
			};
			Parameters<double> projectionParameters = new Parameters<double>()
			{
				XParameter = 30 * (Math.PI / 180),
				YParameter = 30 * (Math.PI / 180),
				ZParameter = 0
			};
			Parameters<double> transferParameters = new Parameters<double>()
			{
				XParameter = 100,
				YParameter = 500, 
				ZParameter = 0
			};
			_figure.Vertexes = rotate.GetTransformation(xrotateParameter) * _figure.Vertexes;
			_figure.Vertexes = yrotate.GetTransformation(yrotateParameter) * _figure.Vertexes;
			_figure.Vertexes = scaling.GetTransformation(scalingParameters) * _figure.Vertexes;
			_figure.Vertexes = transfer.GetTransformation(transferParameters) * _figure.Vertexes;
			_figure.Vertexes = projection.GetTransformation(projectionParameters) * _figure.Vertexes;			
		}

		private void canvas_Paint(object sender, PaintEventArgs e)
		{
			_figure.Draw(e.Graphics);
		}
	}
}
