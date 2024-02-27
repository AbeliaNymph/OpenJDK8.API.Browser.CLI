
namespace Core.Commands.Impl;

public class SearchCommand : ICommand
{
    public string Execute(List<string> args)
    {
        throw new NotImplementedException();
    }

    public bool IsSupport(List<string> args)
    {
        return args.Count == 2 && args[0].Equals("search");
    }
}
