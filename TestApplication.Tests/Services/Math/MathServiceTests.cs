using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApplication.Services.Math;

namespace TestApplication.Tests.Services.Math
{
    [TestClass]
    public class MathServiceTests
    {
        MathService _target;

        [TestInitialize]
        public void Initialize()
        {
            _target = new MathService();
        }

        #region Add Tests

        [TestMethod]
        public void Add_WorksCorrectly_WhenBothNumbersArePositive()
        {
            var expectedResult = 3d;

            var actualResult = _target.Add(1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_WorksCorrectly_WhenFirstNumberIsPositiveAndSecondNumberIsNegative()
        {
            var expectedResult = -1d;

            var actualResult = _target.Add(1, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_WorksCorrectly_WhenFirstNumberIsNegativeAndSecondNumberIsPositive()
        {
            var expectedResult = 1d;

            var actualResult = _target.Add(-1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_WorksCorrectly_WhenBothNumbersAreNegative()
        {
            var expectedResult = -3d;

            var actualResult = _target.Add(-1, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region Divide Tests

        [TestMethod]
        public void Divide_WorksCorrectly_WhenBothNumbersArePositive()
        {
            var expectedResult = 1d / 2d;

            var actualResult = _target.Divide(1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Divide_WorksCorrectly_WhenFirstNumberIsPositiveAndSecondNumberIsNegative()
        {
            var expectedResult = 1d / -2d;

            var actualResult = _target.Divide(1, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Divide_WorksCorrectly_WhenFirstNumberIsNegativeAndSecondNumberIsPositive()
        {
            var expectedResult = -1d / 2d;

            var actualResult = _target.Divide(-1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Divide_WorksCorrectly_WhenBothNumbersAreNegative()
        {
            var expectedResult = 1d / 2d;

            var actualResult = _target.Divide(-1, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region Multiply Tests

        [TestMethod]
        public void Multiply_WorksCorrectly_WhenBothNumbersArePositive()
        {
            var expectedResult = 1d * 2d;

            var actualResult = _target.Multiply(1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Multiply_WorksCorrectly_WhenFirstNumberIsPositiveAndSecondNumberIsNegative()
        {
            var expectedResult = 1d * -2d;

            var actualResult = _target.Multiply(1, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Multiply_WorksCorrectly_WhenFirstNumberIsNegativeAndSecondNumberIsPositive()
        {
            var expectedResult = -1d * 2d;

            var actualResult = _target.Multiply(-1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Multiply_WorksCorrectly_WhenBothNumbersAreNegative()
        {
            var expectedResult = 1d * 2d;

            var actualResult = _target.Multiply(-1, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region Squared Tests

        [TestMethod]
        public void Squared_WorksCorrectly_WhenNumberIsPositive()
        {
            var expectedResult = 9d;

            var actualResult = _target.Squared(3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Squared_WorksCorrectly_WhenNumberIsNegative()
        {
            var expectedResult = 9d;

            var actualResult = _target.Squared(-3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region SquareRoot Tests

        [TestMethod]
        public void SquaredRoot_WorksCorrectly_WhenNumberIsPositive()
        {
            var expectedResult = 3d;

            var actualResult = _target.SquareRoot(9);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SquaredRoot_WorksCorrectly_WhenNumberIsNegative()
        {
            var expectedResult = double.NaN;

            var actualResult = _target.SquareRoot(-9);

            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region Add Tests

        [TestMethod]
        public void Subtract_WorksCorrectly_WhenBothNumbersArePositive()
        {
            var expectedResult = -1d;

            var actualResult = _target.Subtract(1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Subtract_WorksCorrectly_WhenFirstNumberIsPositiveAndSecondNumberIsNegative()
        {
            var expectedResult = 3d;

            var actualResult = _target.Subtract(1, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Subtract_WorksCorrectly_WhenFirstNumberIsNegativeAndSecondNumberIsPositive()
        {
            var expectedResult = -3d;

            var actualResult = _target.Subtract(-1, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Subtract_WorksCorrectly_WhenBothNumbersAreNegative()
        {
            var expectedResult = 1d;

            var actualResult = _target.Subtract(-1, -2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion
    }
}