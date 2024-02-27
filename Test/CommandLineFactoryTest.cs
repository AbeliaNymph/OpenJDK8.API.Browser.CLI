
using Core.Commands.AddCommand.Impl;
using Core.Commands.SearchCommand.Impl;

namespace Test;

public class CommandLineFactoryTest
{

    private CommandLineFactory _factory;
    
    [SetUp]
    public void SetUp() 
    {
        _factory = new();
        _factory.SignIn(new AddCommand());
        _factory.SignIn(new SearchCommand(new FakeClassRepository()));
    }

    
    [Test]
    public void Generate_InputSearchString_GenerateSearchCommand()
    {
        List<string> args = ["search", "String"];

        ICommand obtained = _factory.Generate(args);

        Assert.That(obtained, Is.InstanceOf(typeof(SearchCommand)));
    }

    [Test]
    public void Generate_InputAddString_GenerateAddCommand()
    {
        List<string> args = ["add", "--className=String"];

        ICommand obtained = _factory.Generate(args);

        Assert.That(obtained, Is.InstanceOf(typeof(AddCommand)));
    }
}
