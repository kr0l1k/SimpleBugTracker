using ModelsRepository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBReprository
{
    public class BugTrackerRepository : BaseRepository, IBugTrackerRepository
    {
        public BugTrackerRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

        public async Task<List<Bug>> GetBugs()
        {
            var result = new List<Bug>() { };

            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                {
                    var query = context.Bugs.AsQueryable();

                    result = query.ToList<Bug>();


                }
            }

            return result;
        }
    }
}
