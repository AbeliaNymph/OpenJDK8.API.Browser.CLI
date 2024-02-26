
namespace Core;

public interface ICommand
{
    void Execute(List<string> args);
}
