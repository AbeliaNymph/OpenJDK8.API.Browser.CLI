using Core.Domain;

namespace Core;

public interface IClassRepository
{
    Classes FindListByName(string name);
    
}
