using System;
using System.Numerics;
using ExtendedArithmetic;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestFixture(Category = "PolynomialArithmetic - Float")]
	public class PolynomialArithmetic_Float : PolynomialArithmetic<float>
	{
		[Test]
		[TestCase("32766", "31", "3", "1.0998623*X^3 + 0.001953125")]
		public override void MakeCoefficientsSmaller(string value, string polybase, string forceDegree, string expected)
		{
			if (!Helpers.TargetFramework.IsNetCore3_1OrGreater())
			{
				expected = "1.099862*X^3 + 0.001953125";
			}
			base.MakeCoefficientsSmaller(value, polybase, forceDegree, expected);
		}
	}
}
