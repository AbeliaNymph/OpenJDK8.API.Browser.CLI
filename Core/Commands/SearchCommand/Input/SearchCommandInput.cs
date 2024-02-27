namespace Core.Commands.SearchCommand.Input;

public class SearchCommandInput(string name)
{
    public string Name { get; } = name;
}
