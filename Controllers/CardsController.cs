using BjApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BjApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        //not implemented
        private readonly ICardRepo _repo;

        public CardsController(ICardRepo repo)
        {
            _repo = repo;
        }
        // GET: CardsController
        [HttpGet]
        public ActionResult Index()
        {
            var card = _repo.GetAllCards();
            return Ok(card);
        }
        [HttpGet("{id}")]
        public ActionResult Index(int id)
        {
            var card = _repo.GetCard();
            _repo.AddCard(card);
            _repo.SaveChanges();            
            return Ok(card);
        }
    }
}
