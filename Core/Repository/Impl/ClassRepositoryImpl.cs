using Core.Domain;
using Core.ORM;

namespace Core;

public class ClassRepositoryImpl : IClassRepository
{
    public Classes FindListByName(string name)
    {
        ApplicationDbContext db = new();

        List<AClass> aClasses = db.Classes
            .Where(it => it.Name == name)
            .Select(each => new AClass(each.Name, each.PackageName))
            .ToList();

        Classes classes = new();

        classes.AddAll(aClasses);

        return classes;
    }
}
