using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repository
{
    public interface ITestRepository
    {
        Task<object> GenerateStuff(int expireDays, object objetctTest);
    }
}
