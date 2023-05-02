using System;
using NUnit.Framework;

namespace TestGenericPolynomial
{
	[TestFixture(Category = "TypeArithmetic - Decimal")]
	public class TypeArithmetic_Decimal : TypeArithmetic<Decimal>
	{
		[Test]
		[TestCase("2981", "8.00001409367807")]
		public override void Ln(string argument, object expected)
		{
			base.Ln(argument, decimal.Parse(expected.ToString()));
		}
	}
}
