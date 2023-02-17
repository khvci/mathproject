namespace MathLibrary
{
    public class BasicMath
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Multiply(double num1, double num2)
        {
            // to trace error while testing, write + instead of * operator
            return num1 + num2;
        }
    }
}
