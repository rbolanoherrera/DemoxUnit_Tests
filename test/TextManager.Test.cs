namespace test;

using Xunit;
using TextManager;

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
        Assert.NotEqual(0, result.Count);
    }
    
}