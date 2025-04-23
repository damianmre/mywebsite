using mywebapi.Models;

namespace mywebapi.Repositories.IRepositories;

public interface IWoordenschatRepository
{
    Task<IEnumerable<Woorden>> GetWoordenAsync();
}
