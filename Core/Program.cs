using Core;

internal class Program
{
    //oj8api search String
    //oj8api add    
    private static void Main(List<string> args)
    {
        CommandLineFactory factory = new();

        factory.append(new SearchCommand());
        factory.append(new AddCommand());

        ICommand command = factory.Generate(args);

        command.Execute(args)
    }
}