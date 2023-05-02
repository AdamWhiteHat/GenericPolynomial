using System;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestFixture(Category = "TypeArithmetic - Double")]
	public class TypeArithmetic_Double : TypeArithmetic<Double>
	{
		[Test]
		[TestCase("2981", "8.000014093678072")]
		public override void Ln(string argument, object expected)
		{
			base.Ln(argument, Double.Parse(expected.ToString(), System.Globalization.CultureInfo.CurrentCulture));
		}
	}
}
