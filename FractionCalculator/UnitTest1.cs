using NUnit.Framework;

namespace FractionCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // arrange
            var fraction1 = new Fraction { Numerator = 0, Denominator = 0 };
            var fraction2 = new Fraction { Numerator = 0, Denominator = 0 };

            // act
            var result = new FractionCalculator().Add(fraction1, fraction2);

            // assert
            Assert.AreEqual(result, new Fraction { Numerator = 0, Denominator = 0 }, "Result should be 0.");
        }

        [Test]
        public void Test2()
        {
            // arrange
            var fraction1 = new Fraction { Numerator = 0, Denominator = 0 };
            var fraction2 = new Fraction { Numerator = 1, Denominator = 2 };

            // act
            var result = new FractionCalculator().Add(fraction1, fraction2);

            // assert
            Assert.AreEqual(result, new Fraction { Numerator = 1, Denominator = 2 }, "Result should be 1/2.");
        }


        private class FractionCalculator
        {
            public Fraction Add(Fraction fraction1, Fraction fraction2)
            {
                return new Fraction { Numerator = 0, Denominator = 0 };
            }
        }

        private struct Fraction
        {
            public int Numerator { get; set; }
            public int Denominator { get; set; }
        }
    }
}