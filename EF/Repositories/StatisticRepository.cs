﻿using Confectionery.DAL.EF;
using Confectionery.DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Confectionery.DAL.Repositories
{
    class StatisticsRepository : IStatisticsRepository
    {
        readonly ConfectioneryDbContext context;
        public StatisticsRepository(ConfectioneryDbContext context) => this.context = context;
        public ICollection<Statistics> GetStatistics()
        {
            return context.Statistics.ToList();
        }

        public void Add(Statistics statistics)
        {
            var s = context.Statistics.Where(s => s.ProductId == statistics.ProductId).FirstOrDefault();
            if (s == default(Statistics))
            {
                context.Statistics.Add(statistics);
            }
            else
            {
                s.Purchased += statistics.Purchased;
                s.PurchasedSeparately += statistics.PurchasedSeparately;
            }
        }
    }
}
