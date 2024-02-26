
namespace Core;

public class CommandLineFactory
{
    private List<ICommand> _commands = [];

    public ICommand Generate(List<string> args)
    {
        return new SearchCommand();
    }

    
}
