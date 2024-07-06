using Calculator.Backend;
using calculator_backend.Services;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
using Xunit.Abstractions;

namespace Calculator.Backend.Test
{
    public class CalculatorServiceTest
    {
        
        private CalculatorService _Service = new CalculatorService();
        [Fact]
        public void TestAdd()
        {
            var result = _Service.Add(1, 2);
            Assert.Equal(3, result);
            result = _Service.Add(2, 3);
            Assert.Equal(5, result);
            result = _Service.Add(-2, 3);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestSubtract()
        {
            var result = _Service.Subtract(1, 2);
            Assert.Equal(-1, result);
            result = _Service.Subtract(3, 1);
            Assert.Equal(2, result);
            result = _Service.Subtract(-2, -3);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestDivide()
        {
            var result = _Service.Divide(1, 2);
            Assert.Equal(0.5, result);
            result = _Service.Divide(3, 1);
            Assert.Equal(3, result);
            Assert.Throws<DivideByZeroException>(() => _Service.Divide(1, 0));
        }


        [Fact]
        public void TestMultiply()
        {
            var result = _Service.Multiply(1, 2);
            Assert.Equal(2, result);
            result = _Service.Multiply(-3, -2);
            Assert.Equal(6, result);
            result = _Service.Multiply(-3, 2);
            Assert.Equal(-6, result);
        }

    }
}