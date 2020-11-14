namespace TestApplication.Services.Math
{
    public class MathService : IMathService
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Squared(double x)
        {
            return x * x;
        }

        public double SquareRoot(double x)
        {
            return System.Math.Sqrt(x);
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}