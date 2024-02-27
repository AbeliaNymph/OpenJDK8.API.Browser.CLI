namespace Core;

public class AClass(string name, string packageName) : IToDisplayString
{
    public string Name { get; } = name;
    public string PackageName { get; } = packageName;

    public string ToDisplayString()
    {
        return $"{PackageName}.{Name}";
    }
}
