
namespace Core;

public class CommandLineFactory
{
    public ICommand Generate(List<string> args)
    {
        return new SearchCommand();
    }
}
