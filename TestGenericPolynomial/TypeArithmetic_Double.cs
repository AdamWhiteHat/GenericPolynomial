using System;
using NUnit.Framework;

namespace TestGenericPolynomial
{
    [TestFixture(Category = "TypeArithmetic - Double")]
    public class TypeArithmetic_Double : TypeArithmetic<Double>
    {
        [Test]
        [TestCase("2981", "8.000014093678072")]
        public override void Ln(string argument, string expected)
        {
            base.Ln(argument, expected);
        }
    }
}
