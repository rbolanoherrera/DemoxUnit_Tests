namespace test;

using Xunit;

public class CalculatorTest
{
    [Fact]
    public void Sum()
    {
        //Arrange
        int valor1 = 4;
        int valor2 = 5;

        //Act
        Calculator cal = new Calculator();
        int result = cal.Sum(valor1, valor2);

        //Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void Sum_Cero()
    {
        //Arrange
        int valor1 = 0;
        int valor2 = 5;

        //Act
        Calculator cal = new Calculator();
        int result = cal.Sum(valor1, valor2);

        //Assert
        Assert.Equal(5, result);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a">valor 1</param>
    /// <param name="b">valor 2</param>
    /// <param name="esperado">valor esperado de la suma que se realizara</param>
    [Theory]
    [InlineData(2,5, 7)]
    [InlineData(2,8, 10)]
    public void Sum_dinamica(int a, int b, int esperado)
    {
        Calculator cal = new Calculator();
        int result = cal.Sum(a, b);

        //Assert
        Assert.Equal(esperado, result);
    }

    [Fact(Skip = "Esta prueba deber ser omitida")]
    public void Sum_errada()
    {
        Calculator cal = new Calculator();
        int result = cal.Sum(2, 3);

        //Assert
        Assert.NotEqual(10, result);
    }

}
