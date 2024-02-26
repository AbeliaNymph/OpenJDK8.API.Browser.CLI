
namespace Test;

public class CommandLineFactoryTest
{
    
    [SetUp]
    public void SetUp() 
    {

    }

    
    [Test]
    public void TestGenerate_01()
    {
        List<string> args = ["search", "String"];

        CommandLineFactory factory = new();

        ICommand obtained = factory.Generate(args);

        Assert.That(obtained, Is.InstanceOf(typeof(SearchCommand)));
    }

    [Test]
    public void TestGenerate_02()
    {
        List<string> args = ["add", "--className=String"];

        CommandLineFactory factory = new();

        ICommand obtained = factory.Generate(args);

        Assert.That(obtained, Is.InstanceOf(typeof(AddCommand)));
    }
}
