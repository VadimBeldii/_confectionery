using Confectionery.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Confectionery.DAL.Repositories
{
    public interface IStatisticsRepository
    {
        public ICollection<Statistics> GetStatistics();
        public void Add(Statistics statistics);
    }
}
