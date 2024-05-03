using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    
    public CalculatorImp buildClass()
    {
        string data = "03/05/2024";
        CalculatorImp calc = new CalculatorImp(data);

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void SumTest(int num1, int num2, int result)
    {
        CalculatorImp calc = buildClass();
        int calculatorResult = calc.Sum(num1, num2);

        Assert.Equal(result, calculatorResult);
    }

    [Theory]
    [InlineData (2, 1, 1)]
    [InlineData (10, 5, 5)]
    public void SubtractTest(int num1, int num2, int result)
    {
        CalculatorImp calc = buildClass();
        int calculatorResult = calc.Subtract(num1, num2);

        Assert.Equal(result, calculatorResult);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void MultiplyTest(int num1, int num2, int result)
    {
        CalculatorImp calc = buildClass();
        int calculatorResult = calc.Multiply(num1, num2);

        Assert.Equal(result, calculatorResult);
    }

    [Theory]
    [InlineData (10, 2, 5)]
    [InlineData (15, 5, 3)]
    public void DivideTest(int num1, int num2, int result)
    {
        CalculatorImp calc = buildClass();
        int calculatorResult = calc.Divide(num1, num2);

        Assert.Equal(result, calculatorResult);
    }

    [Fact]
    public void TestDivisionByZero()
    {
        CalculatorImp calc = buildClass();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(3,0));
    }

    [Fact]
    public void TestHistoric()
    {

        CalculatorImp calc = buildClass();
        
        calc.Sum(1, 2);
        calc.Sum(2, 3);
        calc.Sum(4, 5);
        calc.Sum(6, 7);

        var list = calc.historic();

        Assert.NotEmpty(list);
        Assert.Equal(3, list.Count);
    }
}