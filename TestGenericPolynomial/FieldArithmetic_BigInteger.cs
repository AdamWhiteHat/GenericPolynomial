using System;
using System.Numerics;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigInteger))]
	[TestFixture(Category = "FieldArithmetic - BigInteger")]
	public class FieldArithmetic_BigInteger : FieldArithmetic<BigInteger>
	{
	}
}
