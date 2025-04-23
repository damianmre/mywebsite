using mywebapi.Models;
using mywebapi.Repositories.IRepositories;

namespace mywebapi.Services;

public class WoordenschatService
{
    private readonly IWoordenschatRepository _woordenschatRepository;
    
    public WoordenschatService(IWoordenschatRepository woordenschatRepository)
    {
        _woordenschatRepository = woordenschatRepository;
    }

    public async Task<IEnumerable<Woorden>> GetWoordenAsync()
    {
        return await _woordenschatRepository.GetWoordenAsync();
    }
}
