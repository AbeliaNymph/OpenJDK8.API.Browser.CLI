
namespace Core;

public interface ICommand
{
    string Execute(List<string> args);
    bool IsSupport(List<string> args);
}
