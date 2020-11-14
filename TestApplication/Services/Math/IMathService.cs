namespace TestApplication.Services.Math
{
    public interface IMathService
    {
        double Add(double x, double y);
        double Multiply(double x, double y);
        double Subtract(double x, double y);
        double Divide(double x, double y);
        double SquareRoot(double x);
        double Squared(double x);
    }
}