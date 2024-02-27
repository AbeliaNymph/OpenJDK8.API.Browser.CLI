using Core.Commands;

namespace Core;

public class CommandLineFactory
{
    private readonly List<ICommand> _commands = [];

    public ICommand Generate(List<string> args)
    {
        return _commands.First(each => each.IsSupport(args));
    }

    public void SignIn(ICommand command)
    {
        _commands.Add(command);
    }
}
