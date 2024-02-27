
namespace Core.Commands;

public interface ICommand
{
    string Execute(List<string> args);
    bool IsSupport(List<string> args);
}
