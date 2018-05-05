using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ModelsRepository;
using DBReprository;
using System.Threading.Tasks;

namespace SimpleBugTracker.Controllers
{
    public class MainController
    {
        [Route("api/[controller]")]
        public class ValuesController : Controller
        {
            static readonly List<User> _users;
            IBugTrackerRepository _blogRepository;

            public ValuesController(IBugTrackerRepository blogRepository)
            {
                _blogRepository = blogRepository;
            }

            [Route("page")]
            [HttpGet]
            public async Task<List<Bug>> GetBugs()
            {
                return await _blogRepository.GetBugs();
            }
        }
    }
}
