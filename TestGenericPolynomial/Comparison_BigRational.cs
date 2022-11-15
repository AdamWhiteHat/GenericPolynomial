using ExtendedNumerics;
using NUnit.Framework;
using System.Numerics;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigRational))]
	[TestFixture(Category = "Comparison - BigRational")]
	public class Comparison_BigRational : Comparison<BigRational>
	{
	}
}
