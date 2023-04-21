using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary
{
	public static class Validator
	{
		public static bool NotNanMoreZero(double value) => (value <= 0 || double.IsNaN(value)) ? false : true;
	}
}
