namespace AGV.IPValidator.Test;

public class Tests
{

    private static readonly IIPValidator _actions = new IPValidator();

    [SetUp]
    public void Setup()
    {
 
    }

    [TestCase("192.168.0.0/255.255.255.0", "192.168.0.10",true)]
    [TestCase("192.168.0.0/255.255.255.0", "192.168.1.1",false)]
    [TestCase("192.168.0.0/20", "192.168.0.10",true)]
    [TestCase("192.168.0.10", "192.168.0.10",true)]
    public void Test(string ipRange, string ip, bool result)
    {
        var res = _actions.isIPinRange(ip, ipRange);
        Assert.That(res, Is.EqualTo(result));
    }
}