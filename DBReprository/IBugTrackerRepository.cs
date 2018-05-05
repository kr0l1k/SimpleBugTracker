using ModelsRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBReprository
{
    public interface IBugTrackerRepository
    {
        Task<List<Bug>> GetBugs();
    }
}