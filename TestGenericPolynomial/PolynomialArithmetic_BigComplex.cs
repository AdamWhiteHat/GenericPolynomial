using ExtendedNumerics;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigComplex))]
	[TestFixture(Category = "PolynomialArithmetic - BigComplex")]
	public class PolynomialArithmetic_BigComplex : PolynomialArithmetic<BigComplex>
	{
	}
}
