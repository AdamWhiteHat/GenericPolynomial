using System.Numerics;
using ExtendedNumerics;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigInteger))]
	[TestFixture(Category = "Comparison - BigInteger")]
	public class Comparison_BigInteger : Comparison<BigInteger>
	{
	}
}
