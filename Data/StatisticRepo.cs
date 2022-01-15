using BjApi.Models;
using System.Collections.Generic;

namespace BjApi.Data
{
    public class StatisticRepo : IStatisticsRepo
    {

        public AppDbContext _context { get; }

        public StatisticRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddStatistics(Statistic statistic)
        {
            _context.statistics.Add(statistic);
        }

       

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public IEnumerable<Statistic> GetStatistics()
        {
            return _context.statistics;

        }
    }
}
