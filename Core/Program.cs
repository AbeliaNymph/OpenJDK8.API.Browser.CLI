using Core;
using Core.Commands;
using Core.Commands.AddCommand.Impl;
using Core.Commands.SearchCommand.Impl;

internal class Program
{
    //oj8api search String
    //oj8api add    
    private static void Main(string[] args)
    {
        CommandLineFactory factory = new();

        factory.SignIn(new AddCommand());
        factory.SignIn(new SearchCommand(new ClassRepositoryImpl()));

        List<string> argList = new(args);
        
        ICommand command = factory.Generate(argList);

        try {
            string result = command.Execute(argList);
            Console.WriteLine(result);
        }
        catch (Exception) {
            Console.Error.WriteLine("发生了未知错误");
        }
        
    }
}