using exam_prog;
using NUnit.Framework;

namespace examTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        double result = myprog.Method(2,  2,  2);
        Assert.AreEqual(6, result);
    }
}