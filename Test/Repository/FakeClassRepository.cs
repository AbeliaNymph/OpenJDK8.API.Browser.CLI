using Core.Domain;

namespace Test;

public class FakeClassRepository : IClassRepository
{
    public Classes FindListByName(string name)
    {
        if (name == "String") {
            Classes classes = new();
            classes.Add(new AClass("String", "java.lang"));

            return classes;
        }
        else if (name == "Boolean") {
            Classes classes = new();
            classes.Add(new AClass("Boolean", "java.lang"));

            return classes;
        }

        throw new NotImplementedException();
    }
}
