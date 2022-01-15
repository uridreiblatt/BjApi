using BjApi.Data;
using BjApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BjApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserScoreController : Controller
    {
        private readonly IUserScoreRepo _repo;

        public UserScoreController(IUserScoreRepo repo)
        {
            _repo = repo;
        }

        // GET: UserScoreController
        //[HttpGet]
        //public ActionResult Index()
        //{
        //    var UserScore = _repo.GetAllUserScore();
        //    if(UserScore == null) return NotFound();
        //    return Ok(UserScore);
        //}
        [HttpGet("{id}", Name = "Details")]
        // GET: UserScoreController/Details/5
        public ActionResult Details(int id)
        {
            var UserScore = _repo.GetUserScore(1); //for demo only
            if (UserScore == null) return NotFound();
            return Ok(UserScore);
        }





        //// POST: UserScoreController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult<UserScore> Edit( UserScore userScore)
        {
            try
            {
                _repo.UpdateUserScore(userScore);
                _repo.SaveChanges();
                return Ok(userScore);
            }
            catch(Exception er)
            {
                return BadRequest(er.Message);
            }
        }


    }
}
