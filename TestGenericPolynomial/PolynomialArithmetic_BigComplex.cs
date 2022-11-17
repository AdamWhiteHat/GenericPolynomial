using ExtendedNumerics;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigComplex))]
	[TestFixture(Category = "PolynomialArithmetic - BigComplex")]
	public class PolynomialArithmetic_BigComplex : PolynomialArithmetic<BigComplex>
	{
		public override void TestIndefiniteIntegral(string polynomial, string expected)
		{
		}

		public override void TestReciprocalPolynomial(string polynomial, string expected)
		{
		}

		public override void TestFactor(string polynomial, string[] expected)
		{
		}
	}
}
