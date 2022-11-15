using ExtendedNumerics;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigDecimal))]
	[TestFixture(Category = "PolynomialArithmetic - BigDecimal")]
	public class PolynomialArithmetic_BigDecimal : PolynomialArithmetic<BigDecimal>
	{
		public override void MakeCoefficientsSmaller(string value, string polybase, string forceDegree, string expected)
		{
			//base.MakeCoefficientsSmaller(value, polybase, forceDegree, expected);
		}
	}
}
