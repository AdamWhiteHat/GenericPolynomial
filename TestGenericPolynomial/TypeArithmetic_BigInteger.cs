using System.Numerics;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigInteger))]
	[TestFixture(Category = "TypeArithmetic - BigInteger")]
	public class TypeArithmetic_BigInteger : TypeArithmetic<BigInteger>
	{
	}
}
