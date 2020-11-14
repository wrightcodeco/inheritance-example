namespace TestApplication.Services.Math
{
    public class GeometryService : IGeometryService
    {
        private readonly IMathService _mathService;

        public GeometryService(IMathService mathService)
        {
            _mathService = mathService;
        }

        public double Hypotense(double a, double b)
        {
            var aSquared = _mathService.Squared(a);
            var bSquared = _mathService.Squared(b);
            
            var cSquared = _mathService.Add(aSquared, bSquared);

            return _mathService.SquareRoot(cSquared);
        }
    }
}