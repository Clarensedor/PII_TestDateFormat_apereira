using NUnit.Framework;
namespace TestDateFormat;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DateEmpty()
    {
        const string date = "25/12/1955";
        string algo = DateFormatter.ChangeFormat(date);
        Assert.IsNotNull(algo);
    }
}