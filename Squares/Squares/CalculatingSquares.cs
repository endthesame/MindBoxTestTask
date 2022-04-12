namespace Squares
{
    public class CalculatingSquares
    {
        public static double SquareCirlce(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius value is not corrected, raadius must be => 0");

            double sqaure = Math.PI* radius *radius;
            return sqaure;
        }

        public static double SquareTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <=0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentOutOfRangeException("one of the sides value is not corrected, side must be > 0");

            double p = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }

        public static bool IsTriangleRectangular(double firstSide, double secondSide, double thirdSide) // Не уверен нужно ли было создавать отдельный метод или нужно писать проверку в методе SquareTriangle
        {
            bool result = false;

            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentOutOfRangeException("one of the sides value is not corrected, side must be > 0");

            if ((firstSide * firstSide == secondSide * secondSide + thirdSide * thirdSide) ||
                (secondSide * secondSide == firstSide * firstSide + thirdSide * thirdSide) ||
                (thirdSide * thirdSide == firstSide * firstSide + secondSide * secondSide)) { result = true; }

            return result;
        }
    }
}