using Lab1.Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.FigureBuilders
{
	public abstract class FigureFromFileBuilder : IFigureBuilder
	{
		protected string fileName;
		public virtual string FileName { get => fileName; set => fileName = value; }
		public abstract Figure Build();
	}
}
