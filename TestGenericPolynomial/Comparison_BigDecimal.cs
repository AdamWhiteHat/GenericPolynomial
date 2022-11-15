using ExtendedNumerics;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigDecimal))]
	[TestFixture(Category = "Comparison - BigDecimal")]
	public class Comparison_BigDecimal : Comparison<BigDecimal>
	{
	}
}
