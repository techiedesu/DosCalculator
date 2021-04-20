using MathNet.Symbolics;
using NUnit.Framework;

namespace DosCalculator.Tests
{
    public class Tests
    {
        private ExpressionMatrix _matrix;

        [SetUp]
        public void Setup()
        {
            _matrix = new ExpressionMatrix(4, 4);

            _matrix
                .Set(0, 0, "-λ")
                .Set(1, 0, "λ")
                .Set(2, 0, "0")
                .Set(3, 0, "0")
                .Set(0, 1, "μ")
                .Set(1, 1, "-(λ+μ)")
                .Set(2, 1, "λ")
                .Set(3, 1, "0")
                .Set(0, 2, "0")
                .Set(1, 2, "μ")
                .Set(2, 2, "-(λ+μ)")
                .Set(3, 2, "λ")
                .Set(0, 3, "0")
                .Set(1, 3, "0")
                .Set(2, 3, "μ")
                .Set(3, 3, "-μ");
        }

        [Test]
        public void CalculateDeterminant()
        {
            var matrix = Algebraic.Expand(_matrix.CalculateDeterminant());
            Assert.AreEqual(matrix, Infix.ParseOrThrow("0"));
        }

        [Test]
        public void CalculateSubmatrixDeterminant()
        {
            var matrix = Algebraic.Expand(_matrix.CalculateDeterminant());
            Assert.AreEqual(matrix, Infix.ParseOrThrow("0"));
        }
    }
}