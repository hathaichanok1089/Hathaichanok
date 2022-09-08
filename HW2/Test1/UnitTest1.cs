namespace Test1;

public class UnitTest1
{
    [Fact]
    public static void Test_exchange()
    {
        double[] numtest = Program2.money(1550.50);
        double[] mynum = {1,1,0,1,0,0,0,0,0,1,0};
        Assert.Equal(numtest,mynum);
    }
}
