
namespace Core.Commands.AddCommand.Impl;

public class AddCommand : ICommand
{
    public string Execute(List<string> args)
    {
        throw new NotImplementedException();
    }

    public bool IsSupport(List<string> args)
    {
        return args.Count > 1 && args[0].Equals("add");
    }
}
