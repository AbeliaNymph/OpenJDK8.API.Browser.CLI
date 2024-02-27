
using Core.Commands.SearchCommand.Input;
using Core.Domain;

namespace Core.Commands.SearchCommand.Impl;

public class SearchCommand(IClassRepository classRepository) : ICommand
{
    private readonly IClassRepository _classRepository = classRepository;


    public string Execute(List<string> args)
    {
        SearchCommandInput input = ConvertToInput(args);
        
        Classes classes = _classRepository.FindListByName(input.Name);

        return classes.ToDisplayString();
    }

    private SearchCommandInput ConvertToInput(List<string> args)
    {
        return new SearchCommandInput(args[1]);
    }

    public bool IsSupport(List<string> args)
    {
        return args.Count == 2 && args[0].Equals("search");
    }
}

