using Lab1.Infrastructure.Transformations.Projection;
using Lab1.Infrastructure.Transformations.AffineTransformations.AffineTransformations3D;
using System;
using System.Collections.Generic;
using System.Text;
using Lab1.Infrastructure.Abstractions;

namespace Lab1
{
	public class GarbageContainer
	{
		public AxonometricProjection AxonometricProjection { get; private set; } = new AxonometricProjection();
		public ParallelTransfer3d<double> ParallelTransfer3D { get; private set; } = new ParallelTransfer3d<double>();
		public RotateAroundX3d RotateAroundX3D { get; private set; } = new RotateAroundX3d();
		public RotateAroundY3d RotateAroundY3D { get; private set; } = new RotateAroundY3d();
		public RotateAroundZ3d RotateAroundZ3D { get; private set; } = new RotateAroundZ3d();
		public Scaling3d<double> Scaling3D { get; private set; } = new Scaling3d<double>();

		private Parameters<double> _projectionParameters;
		public Parameters<double> ProjectionParameters =>
			_projectionParameters is null ? new Parameters<double>() :
			FillBy(_projectionParameters, 0);

		private Parameters<double> _transferParameters;
		public Parameters<double> TransferParameters =>
			_transferParameters is null ? new Parameters<double>() :
			FillBy(_transferParameters, 0);

		private Parameters<double> _scalingParameters;
		public Parameters<double> ScalingParameters =>
			_scalingParameters is null ? new Parameters<double>() :
			FillBy(_scalingParameters, 1);

		private Parameters<double> _rotationParameters;
		public Parameters<double> RotationParameters =>
			_rotationParameters is null ? new Parameters<double>() :
			FillBy(_rotationParameters, 0);


		private Parameters<T> FillBy<T>(Parameters<T> parameter, T value)
		{
			parameter.FillBy(value);
			return parameter;
		}
	}
}
