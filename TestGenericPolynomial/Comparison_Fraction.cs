using ExtendedNumerics;
using NUnit.Framework;
using System.Numerics;

namespace TestGenericPolynomial
{
	[TestOf(typeof(Fraction))]
	[TestFixture(Category = "Comparison - Fraction")]
	public class Comparison_Fraction : Comparison<Fraction>
	{
	}
}
