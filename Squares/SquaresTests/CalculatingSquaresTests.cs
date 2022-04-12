using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squares;

namespace SquaresTests
{
    [TestClass]
    public class CalculatingSquaresTests
    {
        [TestMethod]
        public void SquareCirlce_PositiveRadius()
        {
            double radius = 5f;
            double expected = 78.539f;

            double actual = CalculatingSquares.SquareCirlce(radius);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void SquareCirlce_NegativeRadius()
        {
            double radius = -5f;

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => CalculatingSquares.SquareCirlce(radius));
        }

        [TestMethod]
        public void SquareTriangle_AllPositiveValues()
        {
            double firstSide = 2.5f;
            double secondSide = 3.3f;
            double thirdSide = 4f;
            double expected = 4.115f;

            double actual = CalculatingSquares.SquareTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void SquareTriangle_ZeroSide()
        {
            double firstSide = 2.5f;
            double secondSide = 0f;
            double thirdSide = 4f;

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => CalculatingSquares.SquareTriangle(firstSide, secondSide, thirdSide));
        }

        [TestMethod]
        public void SquareTriangle_NegativeSide()
        {
            double firstSide = 2.5f;
            double secondSide = 3f;
            double thirdSide = -4.3f;

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => CalculatingSquares.SquareTriangle(firstSide, secondSide, thirdSide));
        }



    }
}
