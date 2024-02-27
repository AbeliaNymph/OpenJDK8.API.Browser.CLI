

using System.Text;

namespace Core.Domain;

public class Classes : IToDisplayString
{
    private List<AClass> _classes = [];

    public void Add(AClass aClass)
    {
        _classes.Add(aClass);
    }

    public string ToDisplayString()
    {
        StringBuilder stringBuilder = new();

        char enter = '\n';

        foreach (AClass aClass in _classes) {
            stringBuilder.Append(aClass.ToDisplayString()).Append(enter);
        }

        return stringBuilder.ToString();
    }
}
