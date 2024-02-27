using Core.Commands.SearchCommand.Impl;

namespace Test;

public class SearchCommandTest
{
    private SearchCommand _searchCommand;

    [SetUp]
    public void SetUp()
    {
        _searchCommand = new(new FakeClassRepository());
    }

    [Test]
    public void Execute_SearchString_EqualsStringDescription() {

        List<string> input = ["search", "String"];

        string obtained = _searchCommand.Execute(input);

        Assert.That(obtained, Is.EqualTo("java.lang.String\n"));
    }

    [Test]
    public void Execute_SearchBooleanClass_EqualsBooleanDescription() {

        List<string> input = ["search", "Boolean"];

        string obtained = _searchCommand.Execute(input);

        Assert.That(obtained, Is.EqualTo("java.lang.Boolean\n"));
    }
}
