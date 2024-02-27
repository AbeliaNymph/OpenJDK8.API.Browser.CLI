using Core.Commands.SearchCommand.Impl;
using Core.Commands.SearchCommand.Input;

namespace Test;

public class SearchCommandTest
{
    [Test]
    public void Execute_SearchString_EqualsStringDescription() {
        SearchCommand searchCommand = new(new FakeClassRepository());

        List<string> input = ["search", "String"];

        String obtained = searchCommand.Execute(input);

        Assert.That(obtained, Is.EqualTo("java.lang.String"));
    }
}
