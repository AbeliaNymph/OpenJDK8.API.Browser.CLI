using Core.Domain;

namespace Test;

public class FakeClassRepository : IClassRepository
{
    public Classes FindListByName(string name)
    {
        if (name == "String") {
            return new Classes();
        }

        throw new NotImplementedException();
    }
}
