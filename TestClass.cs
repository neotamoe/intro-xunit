using Xunit;

public class TestClass 
{
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    // [InlineData(8)] This will fail
    public void MyFirstTheory(int myTestNumber)
    {
        Assert.True(Program.IsOdd(myTestNumber));
    }

    [Fact]
    public void PassingAddTest() 
    {
        Assert.Equal(4, Program.Add(2,2));
    }

    [Fact]
    public void FailingAddTest() 
    {
        Assert.NotEqual(5, Program.Add(2,2));
    }
}