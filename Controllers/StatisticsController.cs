using BjApi.Data;
using BjApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;

namespace BjApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatisticsController : Controller
    {
        private readonly ILogger<StatisticsController> _logger;
        private readonly IStatisticsRepo _repo;
        public StatisticsController(ILogger<StatisticsController> logger , IStatisticsRepo repo )
        {
            _logger = logger;
            _repo = repo;
        }



        [HttpGet]
        public ActionResult Index()
        {
            var statistics = _repo.GetStatistics();
            if (statistics == null) return NotFound();
            return Ok(statistics);
        }


        // POST: StatisticsController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(Statistic statisticsInfo)
        {
            try
            {
                Console.WriteLine(statisticsInfo);
                _logger.LogWarning(JsonSerializer.Serialize(statisticsInfo));
                _repo.AddStatistics(statisticsInfo);
                _repo.SaveChanges();
            }
            catch(Exception er)
            {
                Console.WriteLine("StatisticsController err: " + er.Message);
                _logger.LogWarning("StatisticsController err: " + er.Message);
            }
            return Ok();
        }

       
    }
}
