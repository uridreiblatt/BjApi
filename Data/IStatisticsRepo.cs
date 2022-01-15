using BjApi.Models;
using System.Collections.Generic;

namespace BjApi.Data
{


    public interface IStatisticsRepo
    {

        IEnumerable<Statistic> GetStatistics();
        void AddStatistics(Statistic  statistic);

        bool SaveChanges();


    }


}