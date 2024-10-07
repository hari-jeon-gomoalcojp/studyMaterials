using MenuPractice;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnSum()
    {
        var calculator = new Calculator();
        var result = calculator.Add(5, 3);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnDifference()
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(5, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_DivideByZero_ThrowsException()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
    }

}