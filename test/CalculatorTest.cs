namespace test;

using Xunit;

public class Class1
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
}
