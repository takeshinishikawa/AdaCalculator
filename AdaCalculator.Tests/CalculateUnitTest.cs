using AdaCalculator;
using Moq;

namespace AdaCalculatorTest
{
    public class CalculateUnitTest
    {
        Moq.Mock<ICalculator> _mock;
        Calculator _calculator;

        public CalculateUnitTest()
        {
            _mock = new();
            _calculator = new();
        }


        [Theory(DisplayName = "Soma dois números double")]
        [Trait("Calcular", "Soma")]
        [InlineData("sum", 1.1, 2.2, 3.3)]
        [InlineData("sum", -1.1, 2.2, 1.1)]
        [InlineData("sum", 1.1, -2.2, -1.1)]
        public void Sum_TwoNumbers_MustBeResult(string operation, double number1, double number2, double result)
        {
            //Arrange
            _mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns((operation, result));
            CalculatorMachine calcMac = new CalculatorMachine(_mock.Object);
            // Act
            (string operation, double result) opMock = calcMac.Calculate(operation, number1, number2);
            (string operation, double result) op = _calculator.Calculate(operation, number1, number2);
            // Assert vs mock
            Assert.Equal(opMock.operation, op.operation);
            Assert.Equal(opMock.result, Math.Round(op.result, 5));

            // Assert vs parameters
            Assert.Equal(operation, op.operation);
            Assert.Equal(result, Math.Round(op.result, 5));
        }

        [Theory(DisplayName = "Soma dois números double")]
        [Trait("Calcular", "Soma")]
        [InlineData("sum", 1.1, 2.2, 3.2)]
        [InlineData("sum", -1.1, 2.2, 1.0)]
        [InlineData("sum", 1.1, -2.2, -1.0)]
        public void Sum_TwoNumbers_MustBeFalse(string operation, double number1, double number2, double result)
        {
            //Arrange
            _mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns((operation, result));
            CalculatorMachine calcMac = new CalculatorMachine(_mock.Object);
            // Act
            (string operation, double result) opMock = calcMac.Calculate(operation, number1, number2);
            (string operation, double result) op = _calculator.Calculate(operation, number1, number2);
            // Assert vs mock
            Assert.False(opMock.result == Math.Round(op.result, 5));

            // Assert vs parameters

            Assert.False(result == Math.Round(op.result, 5));
        }

        [Theory(DisplayName = "Subtração dois números double")]
        [Trait("Calcular", "Subtração")]
        [InlineData("subtract", 1.1, 2.2, -1.1)]
        [InlineData("subtract", -1.1, 2.2, -3.3)]
        [InlineData("subtract", 1.1, -2.2, 3.3)]
        public void Subtract_TwoNumbers_MustBeResult(string operation, double number1, double number2, double result)
        {
            //Arrange
            _mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns((operation, result));
            CalculatorMachine calcMac = new CalculatorMachine(_mock.Object);
            // Act
            (string operation, double result) opMock = calcMac.Calculate(operation, number1, number2);
            (string operation, double result) op = _calculator.Calculate(operation, number1, number2);
            // Assert vs mock
            Assert.Equal(opMock.operation, op.operation);
            Assert.Equal(opMock.result, Math.Round(op.result, 5));

            // Assert vs parameters
            Assert.Equal(operation, op.operation);
            Assert.Equal(result, Math.Round(op.result, 5));
        }

        [Theory(DisplayName = "Subtração dois números double")]
        [Trait("Calcular", "Subtração")]
        [InlineData("subtract", 1.1, 2.2, -1.1)]
        [InlineData("subtract", -1.1, 2.2, -3.3)]
        [InlineData("subtract", 1.1, -2.2, 3.3)]
        public void Subtract_TwoNumbers_MustBeTrue(string operation, double number1, double number2, double result)
        {
            //Arrange
            _mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns((operation, result));
            CalculatorMachine calcMac = new CalculatorMachine(_mock.Object);
            // Act
            (string operation, double result) opMock = calcMac.Calculate(operation, number1, number2);
            (string operation, double result) op = _calculator.Calculate(operation, number1, number2);
            // Assert vs mock
            Assert.True(opMock.operation == op.operation);
            Assert.True(opMock.result == Math.Round(op.result, 5));

            // Assert vs parameters
            Assert.True(operation == op.operation);
            Assert.True(result == Math.Round(op.result, 5));
        }

        [Theory(DisplayName = "Multiplicação dois números double")]
        [Trait("Calcular", "Multiplicação")]
        [InlineData("multiply", 3, 3, 9)]
        [InlineData("multiply", 3.3, 3.3, 10.89)]
        [InlineData("multiply", 1.1, -2.2, -2.42)]
        public void Multiply_TwoNumbers_MustBeResult(string operation, double number1, double number2, double result)
        {
            //Arrange
            _mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns((operation, result));
            CalculatorMachine calcMac = new CalculatorMachine(_mock.Object);
            // Act
            (string operation, double result) opMock = calcMac.Calculate(operation, number1, number2);
            (string operation, double result) op = _calculator.Calculate(operation, number1, number2);
            // Assert vs mock
            Assert.Equal(opMock.operation, op.operation);
            Assert.Equal(opMock.result, Math.Round(op.result, 5));

            // Assert vs parameters
            Assert.Equal(operation, op.operation);
            Assert.Equal(result, Math.Round(op.result, 5));
        }

        [Theory(DisplayName = "Divisão dois números double")]
        [Trait("Calcular", "Divisão")]
        [InlineData("divide", 1, 2, 0.5)]
        [InlineData("divide", 2, 1, 2)]
        [InlineData("divide", 1.1, 2, 0.55)]
        public void Divide_TwoNumbers_MustBeResult(string operation, double number1, double number2, double result)
        {
            //Arrange
            _mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns((operation, result));
            CalculatorMachine calcMac = new CalculatorMachine(_mock.Object);
            // Act
            (string operation, double result) opMock = calcMac.Calculate(operation, number1, number2);
            (string operation, double result) op = _calculator.Calculate(operation, number1, number2);
            // Assert vs mock
            Assert.Equal(opMock.operation, op.operation);
            Assert.Equal(opMock.result, Math.Round(op.result, 5));

            // Assert vs parameters
            Assert.Equal(operation, op.operation);
            Assert.Equal(result, Math.Round(op.result, 5));
        }
    }
}