using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestApplication.Services.Math;

namespace TestApplication.Tests.Services.Math
{
    [TestClass]
    public class GeometryServiceTests
    {
        private Mock<IMathService> _mockMathService;

        private GeometryService _target;

        [TestInitialize]
        public void Initialize()
        {
            _mockMathService = new Mock<IMathService>(MockBehavior.Strict);

            _target = new GeometryService(_mockMathService.Object);
        }

        [TestMethod]
        public void Hypotense_ReturnsSquareRootOfTheSumOfSquares()
        {
            _mockMathService.Setup(x => x.Squared(1))
                            .Returns(111);
            
            _mockMathService.Setup(x => x.Squared(2))
                            .Returns(222);

            _mockMathService.Setup(x => x.Add(111, 222))
                            .Returns(333);

            _mockMathService.Setup(x => x.SquareRoot(333))
                            .Returns(444);

            var expectedResult = 444;

            var actualResult = _target.Hypotense(1, 2);

            Assert.AreEqual(expectedResult, actualResult);

            _mockMathService.Verify(x => x.Squared(1), Times.Once);
            _mockMathService.Verify(x => x.Squared(2), Times.Once);
            _mockMathService.Verify(x => x.Add(111, 222), Times.Once);
            _mockMathService.Verify(x => x.SquareRoot(333), Times.Once);
        }
    }
}
