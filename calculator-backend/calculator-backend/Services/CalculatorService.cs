using calculator_backend.Interfaces;

namespace calculator_backend.Services
{
    public class CalculatorService : ICalculator
    {
        public double Add(double num1, double num2)
        {
           return num1 + num2;
        }

        public double Divide(double numerator, double denominator)
        {

            return denominator == 0 ? throw new DivideByZeroException() : numerator / denominator;
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Subtract(double num1, double num2)
        {
           return num1 - num2;
        }
    }
}
