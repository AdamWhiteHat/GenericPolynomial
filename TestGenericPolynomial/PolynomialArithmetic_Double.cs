using System;
using System.Numerics;
using ExtendedArithmetic;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestFixture(Category = "PolynomialArithmetic - Double")]
	public class PolynomialArithmetic_Double : PolynomialArithmetic<Double>
	{
		[Test]
		[TestCase("32766", "31", "3", "1.099862374542647*X^3 + 3.637978807091713E-12")]
		public override void MakeCoefficientsSmaller(string value, string polybase, string forceDegree, string expected)
		{
			base.MakeCoefficientsSmaller(value, polybase, forceDegree, expected);
		}
	}
}
