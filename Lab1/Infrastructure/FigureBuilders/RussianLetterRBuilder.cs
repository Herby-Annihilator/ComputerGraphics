using Lab1.Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Infrastructure.FigureBuilders
{
	public class RussianLetterRBuilder : FigureFromFileBuilder, IFigureBuilder
	{
		public RussianLetterRBuilder(string fileName)
		{
			FileName = fileName;
		}

		public override Figure Build()
		{
			throw new NotImplementedException();
		}
	}
}
