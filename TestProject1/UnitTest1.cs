namespace TestProject1;

public class Tests
{
    [TestCase]
    public void Add()
    {
        MyMath myMath = new MyMath();
        Assert.AreEqual(31, myMath.Add(20, 11));
    }

    [TestCase]
    public void Sub()
    {
        MyMath myMath = new MyMath();
        Assert.AreEqual(9, myMath.Sub(20, 11));
        
    }
}