
namespace Test;

public class CommandLineFactoryTest
{

    private CommandLineFactory _factory;
    
    [SetUp]
    public void SetUp() 
    {
        _factory = new();
        _factory.SignIn(new AddCommand());
        _factory.SignIn(new SearchCommand());
    }

    
    [Test]
    public void TestGenerate_01()
    {
        List<string> args = ["search", "String"];

        ICommand obtained = _factory.Generate(args);

        Assert.That(obtained, Is.InstanceOf(typeof(SearchCommand)));
    }

    [Test]
    public void TestGenerate_02()
    {
        List<string> args = ["add", "--className=String"];

        ICommand obtained = _factory.Generate(args);

        Assert.That(obtained, Is.InstanceOf(typeof(AddCommand)));
    }
}
