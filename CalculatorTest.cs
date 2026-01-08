using Xunit;

 //innan metod som ska testa
public class CalculatorTest
{
    [Fact]
    public void TestAdd()
    {
    
    //given
    Calculator calc = new();
    int a = 2;
    int b = 5;
    int expectedResult = 7;

    //when
    int result = calc.Add(a,b);

    //then
    Assert.Equal(expectedResult, result);
    }
}