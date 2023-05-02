using ExtendedArithmetic;
using ExtendedNumerics;
using NUnit.Framework;
using System;
using System.Numerics;

namespace TestGenericPolynomial
{
	[TestOf(typeof(BigComplex))]
	[TestFixture(Category = "TypeArithmetic - BigComplex")]
	public class TypeArithmetic_BigComplex : TypeArithmetic<BigComplex>
	{
		public override void Logarithm(string argument, double logBase, string expected)
		{
		}

		public override void Ln(string argument, object expectedObj)
		{
		}
	}
}
