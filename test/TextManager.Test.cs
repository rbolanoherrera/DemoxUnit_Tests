namespace test;

using Xunit;
using TextManager;
using Moq;

public class TextManagerTest
{
    [Fact]
    public void CountWords()
    {
        //arrange
        var textManager = new TextManager("texto de prueba");

        //act
        var result = textManager.CountWords();

        //assert
        Assert.NotEqual(2, result);
    }

    [Fact]
    public void FindRepeatedWords()
    {
        //arrange
        var textMng = new TextManager("el gato de la vecina es muy canzon, el duerme en la calle");

        //act
        var result = textMng.FindWordRepetContinue("el", true);

        //assert
        Assert.NotNull(result);
        Assert.Equal(0, result.Count);
    }

    [Fact]
    public void CountWords_NotZero_Moq()
    {
        //arrange
        var mock = new Mock<TextManager>("La perra de la vecina");
        mock.Setup(p=> p.CountWords()).Returns(1);

        //act
        var result = mock.Object.CountWords();

        //assert
        Assert.NotEqual(0, result);
    }
    
}