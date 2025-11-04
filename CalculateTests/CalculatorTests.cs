using System.Reflection;

namespace Calculate;

public class CalculatorTests
{
    [Fact]
    public void TryCalculate_ValidAddition_ReturnsTrueAndCorrectAnswer()
    {
        //Arrange
        Calculator calc = new();

        //Act
        bool result = calc.TryCalculate("3 + 4", out double answer);

        //Assert
        Assert.True(result);
        Assert.Equal<double>(7.0, answer);
    }

    [Fact]
    public void TryCalculate_InvalidInput_ReturnsFalse()
    {
        //Arrange
        Calculator calc = new();

        //Act
        bool result = calc.TryCalculate("3+4", out double answer);
        bool result2 = calc.TryCalculate("  3 +  4", out double answer2);
        bool result3 = calc.TryCalculate("3-4", out double answer3);
        bool result4 = calc.TryCalculate("3*4", out double answer4);
        bool result5 = calc.TryCalculate("3/4", out double answer5);

        //Assert
        Assert.False(result);
        Assert.False(result2);
        Assert.False(result3);
        Assert.False(result4);
        Assert.False(result5);
    }
    [Fact]
    public void TryCalculate_ValidSubtraction_ReturnsTrueAndCorrectAnswer()
    {
        //Arrange
        Calculator calc = new();

        //Act
        bool result = calc.TryCalculate("6 - 4", out double answer);

        //Assert
        Assert.True(result);
        Assert.Equal<double>(2.0, answer);
    }
    [Fact]
    public void TryCalculate_ValidMultiplication_ReturnsTrueAndCorrectAnswer()
    {
        //Arrange
        Calculator calc = new();

        //Act
        bool result = calc.TryCalculate("2 * 2", out double answer);

        //Assert
        Assert.True(result);
        Assert.Equal<double>(4.0, answer);
    }
    [Fact]
    public void TryCalculate_ValidDivision_ReturnsTrueAndCorrectAnswer()
    {
        //Arrange
        Calculator calc = new();

        //Act
        bool result = calc.TryCalculate("6 / 2", out double answer);

        //Assert
        Assert.True(result);
        Assert.Equal<double>(3.0, answer);
    }
}


