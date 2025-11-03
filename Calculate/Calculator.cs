namespace Calculate;

public class Calculator
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }
        return (double)a / b;
    }
}